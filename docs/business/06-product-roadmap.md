# 06 — Product: What's Built, What's Missing, What to Build Next

> Assessed 2026-09-25 against `master` @ `b16de88` (last touched 2026-03-23).
> Everything under "Verified" was reproduced by building the code, running the tests, and sending requests to the API.

---

## 1. What exists today

~300 lines of C# in two commits: a .NET 8 minimal API that takes raw text plus a category and returns structured JSON from a local LLM.

```
POST /api/process {text, category}
  → PromptFactory       (Medical | Legal | Financial system prompt)
  → OllamaProvider      (llama3 @ localhost:11434)
  → ProcessedDocument   {RequiresManualReview, DocumentCategory, ExtractedData}
```

| Area | Status |
|---|---|
| Build | ✅ Builds on .NET 8 SDK with 1 nullable warning, plus 2 CS9057 warnings: OllamaSharp 5.4.24's source generator needs a newer compiler, so it's skipped (unused here) |
| Tests | ✅ 2 pass, but one is the empty `UnitTest1` template; the real test mocks both dependencies |
| Categories | Medical, Legal, Financial, each with 6 extraction fields |
| Model | `llama3` (Meta, April 2024, 8B parameters, 8K-token context), hardcoded |
| Input | Raw text only (no PDF, Word, or scanned images) |
| UI | None (Swagger in Development only) |
| Security | No auth, no audit log, no TLS configuration, `AllowedHosts: *` |
| Packaging | None (run from source with `dotnet run`) |

### What's genuinely good (keep it)

- **The shape is right.** Category → strict prompt → local model → JSON is exactly the "structured extraction" workflow buyers in these verticals pay for.
- **`RequiresManualReview` is a selling point.** A built-in human-in-the-loop flag lines up with the supervision duties in ABA Formal Opinion 512 and with clinical-safety expectations. Make it prominent in the demo and on the landing page.
- **Clean seams.** `ILocalAiProvider` and `IPromptFactory` make it easy to swap Ollama for vLLM or llama.cpp, or add new categories without touching the orchestration.

---

## 2. Verified issues

Each item below was reproduced, not guessed.

| # | Issue | Where | What happens | Fix |
|---|---|---|---|---|
| 1 | Unknown or wrong-case category crashes | `PromptFactory.cs:12`, `:80` | `"Tax"` or `"medical"` → **HTTP 500** with a stack trace (Development) | Validate input and return 400 with ProblemDetails; make category lookup case-insensitive |
| 2 | Empty text returns success | `ClaimProcessingService.cs:35` | `""` → **HTTP 200 with an empty body** (also the build's only nullable warning) | Return 400 |
| 3 | Model server down → raw 500 | `OllamaProvider.cs:45` | Stack trace leaks; no retry or health check | Catch, return 503, and add `/health` |
| 4 | **Brittle JSON parsing** | `OllamaProvider.cs:55-56` | If the model returns a number (`"total_amount": 1250.00`), a list (`"parties": ["Acme","Doe"]`), or wraps the JSON in markdown code fences, parsing throws. The fallback (`OllamaProvider.cs:68-78`) returns HTTP 200 with `RequiresManualReview: true` and the error text, and nothing is logged, **so a demo shows "needs review" instead of results**. Local models do all three regularly. | Use Ollama/vLLM **structured outputs** (JSON-schema `format`), parse `ExtractedData` as `Dictionary<string, JsonElement>`, and strip code fences before parsing |
| 5 | Long documents silently truncated | `OllamaProvider.cs:15`, `:32-41` | `llama3` caps at 8K tokens (about 12 pages), and the request (`:32-41`) never sets `num_ctx`, so Ollama's default context window, which can be just 4K tokens, applies. Ollama [truncates silently](https://fast.io/resources/ollama-context-window/). A 40-page contract or a 300-page medical record loses most of its content with no warning. | Chunk and map-reduce; use a long-context model; set `num_ctx`; report "pages processed" |
| 6 | System prompt sent twice | `OllamaProvider.cs:26-30`, `:38-39` | Wastes context on every call | Send it once, as the system message |
| 7 | Hardcoded endpoint and model | `OllamaProvider.cs:14-15` | Can't change the model or server without recompiling | Move to `appsettings.json`; support any OpenAI-compatible endpoint |
| 8 | Commercial-license trap in tests | `DocumentProcessor.Specs.csproj:14` | FluentAssertions **8.x** requires a paid Xceed license for commercial use (the test run prints this warning) | Pin FluentAssertions 7.x (Apache-2.0) or switch to AwesomeAssertions or Shouldly |
| 9 | Model license obligations | `OllamaProvider.cs:15` | Meta's Llama 3 license requires "Built with Meta Llama 3" attribution when redistributed, which applies once it ships on a customer box | Prefer Apache-2.0 or MIT models (see [04](04-infrastructure-and-logistics.md#3-models)) or add the attribution |
| 10 | Template leftovers | `DocumentProcessor.Api.http:3`, `UnitTest1.cs` | `.http` file calls `/weatherforecast`; empty test inflates the pass count | Delete or replace |

None of these are hard to fix. Items 1–7 are a week of work together. Items 4 and 5 matter most, because they determine whether a prospect sees correct output during a demo.

---

## 3. The gap between "API prototype" and "something a firm will pay for"

A managing partner or practice administrator will never call a JSON endpoint. What they buy is: *"My staff opens a browser, drops in a 400-page PDF, and gets an accurate summary with page citations, and nothing leaves the building."*

| Capability buyers expect | Today | Needed for |
|---|---|---|
| Upload PDF, Word, email, scans (with OCR) | ❌ text only | Demo |
| Web UI: upload → results → review queue → export (Excel/CSV/Word) | ❌ | Demo |
| Long-document handling with page-level citations | ❌ | Demo |
| Modern local model with enforced JSON output | ❌ llama3 8B | Demo |
| "Chat with our documents" (private ChatGPT with search over firm files) | ❌ | Pilot |
| Login via the firm's Active Directory/LDAP, plus roles | ❌ | Pilot |
| Matter- or patient-level access control (ethical walls) | ❌ | Pilot |
| Audit log (who processed and viewed what, which model version) | ❌ | Pilot (HIPAA §164.312(b) audit controls) |
| Encryption at rest, TLS on the LAN | ❌ | Pilot |
| Accuracy report (field-level precision and recall on test sets) | ❌ | Pilot (makes accuracy claims defensible) |
| Offline installer plus signed offline update bundles | ❌ | First paid install |
| Batch/queue processing for large record sets | ❌ | First paid install |
| Vertical workflows (below) | Partial (3 generic extractors) | Product-market fit |

### Build vs. borrow

Don't build commodity pieces. The value is in the vertical workflows, the security wrapper, and the service.

| Piece | Recommendation |
|---|---|
| Inference server | **vLLM** (or SGLang) on every client box. Ollama handles one request at a time by default, so keep it for development and the demo box. All of them speak the OpenAI-compatible API, so `ILocalAiProvider` needs just one implementation. See [04](04-infrastructure-and-logistics.md#the-serving-engine). |
| Chat UI with document search | Start from a permissively licensed open-source UI: **LibreChat** (MIT) or **AnythingLLM** (MIT). **Open WebUI** is popular but, since v0.6.6 (April 2025), its license [bars removing its branding](https://github.com/open-webui/docs/blob/main/docs/license.mdx) on deployments over 50 users unless you buy an enterprise license. |
| PDF/OCR parsing | Docling (MIT) with Granite-Docling or PaddleOCR-VL (both Apache 2.0) for scans (see [04](04-infrastructure-and-logistics.md#3-models)); Tesseract as a fallback |
| Embeddings and vector search | Qwen3-Embedding (Apache 2.0) plus Postgres + pgvector (one database for app data, audit log, and vectors) |
| Auth | ASP.NET Core Identity + LDAP/AD; OIDC (Entra ID) for firms that allow it |
| **Your differentiator** | The .NET extraction engine: vertical prompts and schemas, citations, the review queue, the audit trail, and the accuracy reports |

---

## 4. Roadmap

Sized for one full-time engineer (the other founder sells). If the founders split their time between building and selling, add ~50%. The weeks match the 90-day plan in [05](05-go-to-market.md#10-first-90-days).

### Phase 0 — Demo-ready (weeks 1–6)

Goal: a 5-minute demo of the medical chronology that runs **with the network cable unplugged**, with accuracy measured before anyone sees it.

- [ ] Fix issues 1–10 above
- [ ] Config-driven model and endpoint; OpenAI-compatible client; a modern Apache-2.0 model
- [ ] Structured-output JSON schemas per category
- [ ] PDF and DOCX upload; OCR for scans
- [ ] Chunking with map-reduce and page citations on every extracted field
- [ ] Minimal web UI: upload → extracted fields with page links → approve/edit (review queue) → export to Excel
- [ ] **Demo dataset built only from synthetic or public data.** Never real client data.
  - Medical: [Synthea](https://github.com/synthetichealth/synthea) synthetic patient records (Apache-2.0)
  - Legal: [CUAD](https://www.atticusprojectai.org/cuad) commercial contracts with clause labels (CC BY 4.0)
  - Financial: synthetic W-2, 1099, and K-1 forms filled from public-domain IRS templates; synthetic bank statements and invoices
- [ ] **Accuracy test set v1:** a small gold-labeled set per workflow, with field-level scores
- [ ] **Medical chronology v1** (weeks 5–6): the beachhead workflow, measured on the test set
- [ ] One-command start: `docker compose up` with models pre-pulled

### Phase 1 — Pilot-ready (weeks 7–13)

Goal: install at 2–3 design-partner firms.

- [ ] Weeks 7–8: portable demo box; offline bundle builder and installer (container images, model weights, checksum manifest, signed)
- [ ] Weeks 7–9, **only if the CPA track is go**: W-2, 1099, and K-1 extraction into a review sheet
- [ ] Weeks 9–10: auth (local accounts plus LDAP/AD), roles (admin, reviewer, user), and workspace/matter-level permissions
- [ ] Weeks 9–10: append-only audit log (user, action, document hash, model and prompt versions, timestamp) and admin page (GPU health, queue depth, model version, disk, last update)
- [ ] **Before each pilot goes live:** run the accuracy check on the client's own sample documents and share the results
- [ ] Weeks 11–13: chat over documents (RAG) with citations, via the borrowed UI above
- [ ] Batch jobs and a queue for large uploads
- [ ] Accuracy harness v2: regression check on every model upgrade
- [ ] Hardening: disk encryption, TLS with the client's internal CA, and an egress-deny firewall profile that proves the box works with no outbound traffic

### Phase 2 — Product-market fit (months 4–9)

Harden what the pilots use, then add workflows from the beachhead segment (see [05](05-go-to-market.md)), not all at once:

| Segment | Workflow | Why it sells |
|---|---|---|
| Litigation (insurance defense, med-mal, PI, workers' comp) | **Medical chronology v2**: hundreds of pages of records → dated timeline of visits, diagnoses, treatments, and gaps, each with page citations, hardened from pilot feedback | Combines the existing Medical and Legal extractors. Paralegals and nurse reviewers spend hours to days per chronology. The records are PHI and privileged work. |
| Law firms (all) | Contract clause extraction against a firm playbook; deposition summaries; discovery first-pass triage | High-volume, repetitive, confidential |
| CPA/tax | W-2, 1099, and **K-1** extraction (v1 in Phase 1 if the CPA track is go); engagement-letter and notice drafting | Busy-season labor crunch, plus IRC §7216 and the FTC Safeguards Rule |
| Healthcare | Prior-authorization letter drafting; chart summarization for referrals; coding suggestions (human-reviewed) | Administrative burden; PHI never leaves |
| Banks/credit unions | Loan-file document extraction; bank-statement analysis; policy Q&A | Third-party-risk scrutiny makes cloud AI slow to approve |

Also in Phase 2:
- [ ] Integrations: export to the firm's document management system; CSV/Excel templates matching their existing review sheets
- [ ] Fleet tooling: version inventory across customer boxes; update-bundle pipeline
- [ ] Multi-GPU scaling on vLLM for 100+ user firms

---

## 5. Engineering principles for this product

1. **Every claim on the landing page needs a test.** "Nothing leaves your network" becomes an automated egress-deny test in CI and in the on-site acceptance checklist.
2. **Citations or it didn't happen.** Every extracted field and every chat answer links to a page. That's the answer to "what about hallucinations?", and it's what lets a lawyer supervise the output as ABA Opinion 512 expects.
3. **Measure accuracy before you sell it.** Publish per-workflow accuracy from your test sets in the pilot proposal. Local models are good but not magic; honest numbers build more trust than a startup's adjectives.
4. **No telemetry by default.** Any outbound connection (updates, health heartbeat) is opt-in, documented, and off in "strict air-gap" mode.
5. **Version everything.** Model, prompt, and schema versions go into every audit record, so any output can be reproduced later, for example when it's challenged in court.
