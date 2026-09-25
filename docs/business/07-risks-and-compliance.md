# 07 — Risks, Legal, and Compliance

> Business-planning notes, **not legal advice**. Budget for a startup lawyer (contracts, trademark) and an insurance broker in Year 1. The cost ranges are in [05](05-go-to-market.md#year-1-go-to-market-and-operating-budget-excluding-salaries).

---

## 1. The name

**Recommendation: don't launch publicly as "AirGappedAI".** Pick a distinctive brand and get a clearance opinion. Use descriptive words like "private" or "works with the internet unplugged" in the tagline, and reserve "air-gapped" for the strict mode (§2).

| Issue | Detail |
|---|---|
| **A competitor already uses a near-identical name in the same market** | Iternal Technologies sells **"AirgapAI"** to law firms (with an ABA 512 page), healthcare, and finance. Dell sells it too, and Dell promoted it at CES 2026 ([iternal.ai](https://iternal.ai/airgapai), [law-firm page](https://iternal.ai/ai-for-law-firms)). It has no USPTO filing, but use in commerce creates common-law rights, which can support a confusion claim. Its parent company (Hanby Technologies) files trademarks regularly (ITERNAL and BLOCKIFY registered; AI ASSIST pending, Apr 2026). |
| **The name is probably unregistrable** | "AirGappedAI" literally describes the product, so the USPTO would likely refuse it as merely descriptive (Lanham Act §2(e)(1)). Nearby marks exist too: Transcend's pending **AIRGAP** and StoneFly's registered **AIR-GAPPED CLOUD** and **AIR GAPPED VAULT**. |
| **The domains are taken** | **airgappedai.com** and **airgappedai.ai** were registered in May 2023 by someone else (unless that's you). **airgapped.ai** is listed for sale at **$89,765**. |

Findings from USPTO and domain-registry lookups on 2026-09-25 (see [02](02-competition.md#iternal-technologies-airgapai-the-closest-one)).

### How to pick the new name (1–2 weeks)

1. Choose **coined or arbitrary** names (a made-up word, or a real word unrelated to AI). Those are the strongest trademarks. Avoid "air", "gap", "vault", "private", "secure", and "local" as the core of the name.
2. Screen 10–20 candidates yourself: the USPTO trademark search (classes 9 and 42), a web search, `.com` availability, and the same name on LinkedIn and GitHub.
3. Take the best 2–3 to a trademark attorney for a clearance search and opinion (typically low thousands of dollars; estimate).
4. File an **intent-to-use** application in classes 9 (software) and 42 (SaaS and IT services) once you've picked one.
5. Put the description in the tagline, e.g., "{Brand}: private AI for law firms that works with the internet unplugged." Descriptive words are fine *next to* a distinctive mark. Say "air-gapped" only about the strict mode, where the box truly has no network path out (§2).

The repo and solution names (`AirGappedAI.sln`, `DocumentProcessor.Api`) are internal and can stay until the brand is chosen.

---

## 2. What you can and can't claim

| Don't say | Say instead | Why |
|---|---|---|
| "HIPAA certified" / "HIPAA compliant" | "Designed to support your HIPAA program; BAA available" | HHS doesn't recognize private HIPAA certifications ([HHS FAQ](https://www.hhs.gov/hipaa/for-professionals/faq/are-we-required-to-certify-our-organizations-compliance-with-the-standards/index.html)). Compliance belongs to the customer's whole program. |
| "ABA approved" / "satisfies Opinion 512" | "Addresses the confidentiality risks Opinion 512 describes" | The ABA doesn't approve products, and 512 also requires competence, supervision, and communication, which only the firm can do. |
| "SOC 2 compliant" | Nothing, until you have the report | Obvious, but it's often fudged |
| "100% accurate" / "no hallucinations" | "Every answer cites its source page; human review built in; measured accuracy on your documents" | 2,078 court cases involve AI hallucinations ([Charlotin](https://www.damiencharlotin.com/hallucinations/)). The FTC has pursued deceptive AI claims (Operation AI Comply, 2024). |
| "Air-gapped" for a box with controlled internet egress | "Network-isolated with scheduled, allowlisted updates" | Only the strict mode is truly air-gapped ([04](04-infrastructure-and-logistics.md#two-connectivity-modes)). Lawyers will check. |
| "Unhackable" / "more secure than the cloud" | "Your data never leaves your network. Here is our security design, pen-test summary, and update process." | NC's ethics opinion warns local servers can be *less* secure than big vendors ([01](01-market-and-regulation.md#state-bar-guidance-selected)). Prove it rather than assert it. |

---

## 3. Contracts to have before the first pilot

| Document | Key points |
|---|---|
| **Pilot agreement** | Fee, credit toward purchase, written success criteria, how their documents are handled and wiped, no warranty on pilot hardware |
| **Master services agreement (MSA) + order form** | Liability capped at 12 months of fees; no consequential damages; **outputs are drafts that require professional review**; you don't provide legal, medical, or tax advice; the client owns all data and outputs; the client is responsible for its own use policies and supervision |
| **Subscription terms** | Term and renewal; what's included; support SLAs; update cadence; what happens at termination (the box keeps running on its last version, and updates stop) |
| **Business associate agreement (BAA)** | Sign one with healthcare clients and with law firms acting as business associates. Support screen shares can expose PHI. HHS publishes [sample provisions](https://www.hhs.gov/hipaa/for-professionals/covered-entities/sample-business-associate-agreement-provisions/index.html). |
| **Data processing / confidentiality terms** | No standing access; client-initiated support only; logged sessions; your staff under confidentiality obligations |
| **Reseller and referral agreements** | Margins, deal registration, support split, brand use (see [05](05-go-to-market.md#7-channels-that-borrow-trust)) |
| **Source-code escrow** (on request) | For larger clients worried about a startup vendor. Standard escrow agents charge an annual fee. |

Budget: ~$3k (templates plus a lawyer's review) to ~$15k (custom drafting).

---

## 4. Your own compliance and security posture

Your product is only as trustworthy as your company's operations. The biggest risk is **your update pipeline**. If an attacker compromised a signed update, every client box would be compromised at once.

| Control | When |
|---|---|
| Release signing keys on hardware tokens (e.g., YubiKey or a hardware security module), with two-person approval for releases | Before the first install |
| Software bill of materials (SBOM) and dependency vulnerability scanning for every release | Before the first install |
| HIPAA program for your company (policies, training, risk analysis): ~$4–15k in Year 1 | Before the first healthcare or PHI-handling client |
| Third-party pen test of the appliance image: ~$4–12k for a small engagement | Before or during the first pilots |
| Security questionnaire kit (SIG Lite or CAIQ answers, whitepaper, diagrams) | Before the first mid-size prospect |
| **SOC 2 Type I**, then Type II: platform ~$14k/year plus audit ~$10–35k | Year 2, or earlier if deals are blocked without it |
| HITRUST e1 (~$27–50k) | Only if selling to hospitals demands it |

Cost sources: [soc2auditors.org](https://soc2auditors.org/soc-2-audit-cost/), [Bright Defense](https://www.brightdefense.com/resources/penetration-testing-pricing/), [Medcurity](https://medcurity.com/hipaa-compliance-cost/), [AvantCert](https://avantcert.com/blog/hitrust-certification-cost) (2026).

Because the box is in the client's office and you never have standing access, SOC 2 scope stays small: your update pipeline, support process, and corporate IT. Keep it that way.

---

## 5. Licensing checklist

| Item | Risk | Action |
|---|---|---|
| **FluentAssertions 8.x** (test dependency) | Paid commercial license required (Xceed) | Pin 7.x (Apache 2.0) or switch to AwesomeAssertions or Shouldly ([06](06-product-roadmap.md#2-verified-issues)) |
| **Llama 3** (current model) | Attribution plus use-policy obligations when redistributed | Replace with Apache-2.0 or MIT models ([04](04-infrastructure-and-logistics.md#3-models)) |
| Gemma-terms models, Jina v4, Chandra/Marker weights, revenue-gated large models | Use restrictions, non-commercial terms, or revenue caps | Don't bundle them |
| **Open WebUI** | Can't remove its branding above 50 users without an enterprise license | Use an MIT-licensed UI or buy the license |
| **NVIDIA GeForce drivers** (e.g., RTX 5090) | "Not licensed for datacenter deployment" | Use RTX PRO cards in client server rooms |
| NVIDIA AI Enterprise | $4,500/GPU/year, needed only for NVIDIA's own NIM containers | Not needed for vLLM, SGLang, or Ollama |
| Everything else | Mostly MIT or Apache 2.0 (OllamaSharp, vLLM, Docling, PaddleOCR, Postgres) | Ship a `THIRD_PARTY_LICENSES` file on every box; have counsel review once |

---

## 6. Insurance

| Policy | Typical startup cost | Notes |
|---|---|---|
| Technology E&O (professional liability) | ~$1,300–3,700/year | **Ask the broker explicitly whether AI-output errors are covered or excluded.** |
| Cyber liability | ~$2,100–2,900/year | Covers breach response. Your update pipeline is the scenario to discuss. |
| General liability | ~$200–450/year | Required by many client contracts |
| D&O | ~$6,300/year | When you take outside investment |

Sources: [Insureon](https://www.insureon.com/technology-business-insurance/cost), [Vouch](https://www.vouch.us/blog/startup-insurance-costs) (2026 averages and medians). Law-firm and healthcare clients will ask for a certificate of insurance, so get coverage before the first pilot.

---

## 7. Risk register

| Risk | Likelihood | Impact | Mitigation |
|---|---|---|---|
| **Name conflict** with Iternal's AirgapAI | High if unchanged | High (forced rebrand after spending on marketing) | Rename now (§1) |
| **"Cloud is compliant enough"** wins most deals | High | Medium | Target buyers with real reasons ([01](01-market-and-regulation.md#2-segment-ranking-and-recommendation)); lead with consent, privilege, and cost; don't argue with cloud-happy firms |
| **Big vendors move down-market** (Dell + Iternal "AI Assist", Dell AI Factory, Cohere North) | Medium | High | Win on vertical workflows, local white-glove service, and MSP partnerships; partner with Dell as a supplier rather than fight it |
| **Hardware price spikes and lead times** | High (2026) | Medium | Thin pass-through pricing, short quote validity, deposits, in-stock channels, 1–2 units of inventory once volume allows ([04](04-infrastructure-and-logistics.md#1-the-2026-hardware-reality-memory-prices-doubled)) |
| **Support load exceeds plan** | Medium | High (EBITDA falls ~44% if support hours double) | Admin page, self-service docs, reliable signed updates, remote diagnostics the client starts |
| **Accuracy failure in front of a client** (hallucinated fact in a chronology) | Medium | High | Citations on every field, a review queue, measured accuracy per workflow, "draft for review" framing in contracts and UI |
| **Compromised update pipeline** | Low | Severe | Hardware-token signing, two-person release approval, SBOM, pen tests |
| **Slow sales** (no reputation, 0.6% cold-email replies) | High | High | Design partners, warm intros, MSP channel, CLE, the Unplugged Demo; hires triggered by client count, not dates ([03](03-pricing-and-unit-economics.md#6-three-year-projection)) |
| **Regulation loosens** (e.g., the Sept 2026 bank vendor-risk proposal) | Medium | Low–medium | Lead with workflows and cost, not only compliance |
| **Regulation tightens** (CA SB 574, HIPAA Security Rule final in 2027) | Medium | **Positive** | Track it and turn it into content and outreach |
| **Founder bandwidth** (selling, building, and installing at once) | High | High | First hire is a field engineer at ~5 clients; keep scope to one vertical and one metro |
| **Sales tax on hardware resale** | Certain if reselling | Low | Register for sales-tax permits where required; use resale certificates; or let clients buy hardware direct ([03](03-pricing-and-unit-economics.md#9-if-clients-buy-hardware-directly)) |
| **Demo data leak** (a prospect's documents left on the demo box) | Low | Severe | Wipe in front of the prospect; encrypted demo box; written demo-data policy ([05](05-go-to-market.md#demo-data-rules)) |
