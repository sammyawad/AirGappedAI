# 04 — Infrastructure and Logistics

> What goes in the box, what it costs, how many people it serves, and how it gets from a supplier to a client's server closet and stays healthy there.
> Prices checked September 2026. **Hardware prices are moving fast. Re-quote before every proposal.**

---

## 1. The 2026 hardware reality: memory prices doubled

The AI build-out created a memory shortage (DRAM, NAND, HBM), and it has pushed up the price of every GPU and server:

| Item | Launch / 2025 price | Sept 2026 price | Source |
|---|---|---|---|
| NVIDIA RTX PRO 6000 Blackwell (96 GB) | $8,565 (Mar 2025) | **$16,000 list**; $18–20k at retail | [Thunder Compute](https://www.thundercompute.com/blog/nvidia-rtx-pro-6000-pricing), [Newegg](https://www.newegg.com/nvidia-blackwell-rtx-pro-6000-96gb-graphic-card/p/N82E16814132106) |
| NVIDIA DGX Spark (128 GB) | $3,999 | **$4,699** | [AiCybr](https://aicybr.com/blog/gb10-ai-workstations-dgx-spark-dell-asus-hp-lenovo) |
| RTX PRO 5000 (48 GB) | $4,199 | **$8,599** | [Newegg](https://www.newegg.com/nvidia-blackwell-900-5g153-2250-000-rtx-pro-5000-48gb-graphics-card/p/N82E16814132111) |
| Framework Desktop (128 GB) | $1,999 | **$3,449** | [ComputingForGeeks](https://computingforgeeks.com/ryzen-ai-max-395-mini-pc-comparison/) |

- DRAM contract prices rose ~55–63% per quarter in the first half of 2026 ([TrendForce Q1](https://www.trendforce.com/presscenter/news/20260105-12860.html), [TrendForce Q2](https://www.trendforce.com/presscenter/news/20260331-12995.html)), and server DRAM is expected to keep rising through 2027 ([TrendForce](https://www.trendforce.com/presscenter/news/20260709-13140.html)).
- **Lead times:** mainstream Dell and Lenovo servers take 6–8 weeks; **AI/GPU systems take 32–52 weeks** through OEM channels ([PCSP](https://pcserverandparts.com/news/server-price-increases-lead-times-2026/)). Some channels ship from stock, for example Supermicro's eStore listing a 4-GPU server that "ships within 24 hours".

**What this means for the business**
1. **Make hardware a thin-margin pass-through and put your margin in the subscription and services.** Hardware margin is volatile. Recurring revenue isn't.
2. **Quotes valid for 7–14 days**, with a hardware price-adjustment clause in every proposal.
3. **Get hardware paid in full on order** (at minimum, a deposit covering your cost), so price swings and lead times never sit on your balance sheet.
4. **Buy from channels that show stock** (retail, distributor, and builder stock), not only from OEM build-to-order.
5. **Once deal flow is steady, keep 1–2 units of the most common tier in inventory.** Faster installs are a selling point.

---

## 2. Recommended hardware tiers

| | **Practice** | **Firm** | **Enterprise** |
|---|---|---|---|
| Team size (pricing tier) | 5–20 users | 20–75 users | 75–300 users |
| Core hardware | 1× GB10 desktop (ASUS Ascent GX10 or NVIDIA DGX Spark), 128 GB unified memory | Workstation with **1× RTX PRO 6000** (96 GB), 128 GB RAM | Tower with **2× RTX PRO 6000 Max-Q** (192 GB GPU memory), Threadripper PRO, 256 GB ECC RAM |
| Reference price | $3,999–4,699 | ~$19,600 (Dell Pro Max T2 configuration) | ~$50–60k (GPUs alone $32–36k) |
| All-in cost (with UPS, backup, and networking) | **~$5,500** | **~$22,300** | **~$58,000** |
| Simultaneous users (short requests) | ~4–8 | ~50 | ~100 |
| Simultaneous long-document jobs (32K tokens) | 1–3 | 6–10 | 15–20 |
| Total staff served | 10–40 | 50–150 | 100–300 |
| Wait before a 30K-token document starts answering | ~15–30 s | ~6–7 s | ~6–7 s |
| Power (typical / peak) | ~100 W / 240 W | ~400 W / 850 W | ~450 W / 900 W |
| Electricity per year (24×7 at $0.13–0.15/kWh) | ~$115–130 | ~$460–530 | ~$510–590 |
| Noise and placement | Silent; on a shelf or desk | Office-quiet tower; closet with ventilation | Quiet water-cooled options (≤46 dB); ventilated closet on a dedicated 20 A circuit |

Capacity figures are from published benchmarks (a single RTX PRO 6000 served **50 concurrent gpt-oss-120b streams at ~31 tokens/s each** under vLLM, per [DatabaseMart](https://www.databasemart.com/blog/vllm-gpu-benchmark-pro6000)). The "staff served" row is an estimate that assumes 5–15% of staff are running a request at the busiest moment.

**Beyond 300 users**, a 4U server with **4× RTX PRO 6000 Server Edition** (384 GB) costs **~$126k** (Supermicro eStore, ships in 24 hours) plus ~$5–15k for 208/240 V power, an online UPS, and cooling. It needs a real server room, since it draws ~3.5 kW at peak (≈ one ton of air conditioning). Treat it as a custom quote. H200 and B200 systems ($370–550k, 10–12 kW) don't make sense for this market.

**Portable demo unit:** an ASUS Ascent GX10 ($3,999) is small enough to carry into a conference room and runs the same software as the Practice tier. It's the Unplugged Demo box (see [05](05-go-to-market.md#4-the-demo)).

### Why not…

| Option | Verdict |
|---|---|
| **Mac Studio (M5 Ultra, from $5,499; 256 GB ≈ $11,299 per [Engadget](https://www.engadget.com/2263184/apple-mac-studio-m5-ultra-review/))** | Quiet and capable for one user or a very small team. For shared serving, a DGX Spark running vLLM finished a batch **3.8× faster** than an M3 Ultra running llama.cpp ([Skorppio](https://skorppio.com/blog/dgx-spark-vs-mac-studio-efficiency-benchmark)). Fine for a solo practitioner; not the default. |
| **AMD Strix Halo mini-PCs ($3,449–4,349, 128 GB, per [ComputingForGeeks](https://computingforgeeks.com/ryzen-ai-max-395-mini-pc-comparison/))** | Cheap, but AMD's GPU software (ROCm) is less mature, and only ~96 GB is usable by the GPU on Linux. Possible budget tier later. |
| **RTX 5090 ($4,300–6,800 street, per [videocardprices](https://videocardprices.com/card/nvidia-rtx-5090/))** | NVIDIA's GeForce driver license says it's "not licensed for datacenter deployment" and never defines the term ([NVIDIA](https://www.nvidia.com/en-us/drivers/geforce-license/)). Don't put consumer cards in client server rooms. Use RTX PRO. |
| **H100 / H200 / B200** | Datacenter GPUs at roughly $25k–55k each ([GPUSmith](https://gpusmith.com/articles/en/nvidia-ai-gpu-price-index-trends), [Thunder Compute](https://www.thundercompute.com/blog/nvidia-b200-pricing)). Overkill and loud. |

---

## 3. Models

### Recommended stack (all permissively licensed for commercial bundling)

Apache-2.0 and MIT models only require shipping the license and notice files with the appliance. That keeps bundling legally simple.

| Job | Model | License | Runs on |
|---|---|---|---|
| Chat and reasoning over documents | **gpt-oss-120b** (OpenAI, 117B total / 5.1B active parameters) | Apache 2.0 | All three tiers |
| Chat, alternative | **Mistral Small 4** (119B, vision, 256K context) or **Nemotron 3 Super** (120B) | Apache 2.0 / NVIDIA Open Model License (check its text) | All three tiers |
| Extraction and summarization (the repo's workflows) | **Qwen3.8-27B** (dense, vision, 262K context) | Apache 2.0 | Firm and Enterprise; Practice at 4-bit |
| Smaller and faster | gpt-oss-20b; IBM Granite 4.2 (3B–30B); Gemma 4 (26B–31B, now Apache 2.0) | Apache 2.0 | All |
| OCR for scanned PDFs | **PaddleOCR-VL** (0.9B, ~45 pages/min on an L40S); **Granite-Docling** (258M, ~80 pages/min on an L40S) | Apache 2.0 | All |
| Heavy OCR / complex layouts | olmOCR 2 (7B) | Apache 2.0 | Firm and Enterprise |
| Embeddings for search | **Qwen3-Embedding** (0.6B / 4B / 8B); BGE-M3 | Apache 2.0 / MIT | All |

Model details and benchmarks from each model's Hugging Face page (for example [Qwen3.8-27B](https://huggingface.co/Qwen/Qwen3.8-27B), [gpt-oss](https://github.com/openai/gpt-oss), [Mistral Small 4](https://huggingface.co/mistralai/Mistral-Small-4-119B-2603), [Qwen3-Embedding-8B](https://huggingface.co/Qwen/Qwen3-Embedding-8B)) and the OCR comparison at [Spheron](https://www.spheron.network/blog/best-open-source-ocr-vlm-self-host-gpu-cloud-2026/).

This replaces the repo's current `llama3` (8B, 8K context, April 2024). The newer models are far more capable and can read ~30× more text in one pass (262K vs. 8K tokens).

### Models and tools to avoid bundling (license traps)

| Model / tool | Why |
|---|---|
| Llama 3 / Llama 4 | Meta's license requires "Built with Llama" attribution and adds usage restrictions |
| MedGemma, EmbeddingGemma | Gemma-specific terms; MedGemma is "not intended to directly inform clinical diagnosis" |
| Jina Embeddings v4 | Non-commercial license |
| Chandra OCR, Marker (model weights) | Free only for companies under $2M / $5M in revenue or funding |
| Kimi K3, Qwen3.8-Max, GLM-5.3, Mistral Medium 3.5 | Revenue-gated or custom licenses (and too large anyway) |

Have a lawyer review the final model list once. Put a `THIRD_PARTY_LICENSES` file on every box.

### The serving engine

| Engine | Use it for |
|---|---|
| **vLLM** (Apache 2.0) | Default for Firm and Enterprise boxes: high throughput for many users |
| **SGLang** (Apache 2.0) | Chat and document Q&A (RAG) with long multi-turn sessions: faster time to first token |
| **Ollama** (MIT) | Development and the demo box. It handles **1 request at a time by default** ([docs](https://docs.ollama.com/faq)). Red Hat measured 41 vs. 793 tokens/s peak against vLLM ([Red Hat](https://developers.redhat.com/articles/2025/08/08/ollama-vs-vllm-deep-dive-performance-benchmarking)). **Not for multi-user production.** |

All three expose an OpenAI-compatible API. That's why the repo's `ILocalAiProvider` should talk that protocol instead of being tied to OllamaSharp.

**NVIDIA AI Enterprise** ($4,500/GPU/year) is **not required** for vLLM, SGLang, llama.cpp, or Ollama. It's only needed for NVIDIA's own NIM containers ([NVIDIA](https://docs.nvidia.com/ai-enterprise/planning-resource/licensing-guide/latest/pricing.html)).

---

## 4. What runs on the box

```
                     ┌──────────────────────────── Client LAN ────────────────────────────┐
  Staff browsers ──► │  Reverse proxy (TLS, client's internal CA)                         │
                     │     │                                                              │
                     │     ▼                                                              │
                     │  Web app (.NET)  ◄──► Postgres + pgvector (app data, vectors,      │
                     │   - upload, review queue, chat     audit log)                      │
                     │   - LDAP/AD login, roles, matter permissions                       │
                     │     │                                                              │
                     │     ├──► OCR worker (PaddleOCR-VL / Docling)                       │
                     │     ├──► Embedding service (Qwen3-Embedding)                       │
                     │     └──► Inference server (vLLM/SGLang) ── LLM weights on disk     │
                     │                                                                    │
                     │  Host: Ubuntu LTS, full-disk encryption, Secure Boot,              │
                     │        default-deny egress firewall                                │
                     └────────────────── no internet access by default ───────────────────┘
```

### Two connectivity modes

| Mode | How it works | For whom |
|---|---|---|
| **Strict air-gap** | No outbound route at all. Updates arrive on encrypted, signed USB media delivered by you or downloaded by the client's IT onto a separate machine. Support is on-site or through a screen share the client starts. | Defense-related work, firms with strict client restrictions, the "never" crowd |
| **Controlled egress** | Outbound blocked except an allowlisted update host during a scheduled maintenance window, plus an optional metadata-only health heartbeat (no documents, no prompts). | Most law, medical, and CPA clients |

Both modes run identically day to day. Only updates and support differ.

---

## 5. Logistics: order to go-live

| Step | Who | Time | Checklist |
|---|---|---|---|
| 1. Site survey | You + client IT/MSP | 1 hr call | Power (circuit, outlets), space, cooling, network (static IP, internal DNS name like `ai.firm.local`), AD/LDAP details, firewall owner, users and roles |
| 2. Order hardware | You | 1 day to order; **1–6+ weeks to arrive** | Deposit received; order from a channel with stock; confirm OEM warranty (3-year on-site next-business-day minimum) |
| 3. Burn-in and imaging | You (in your lab) | 1–2 days | 24-hour GPU and memory stress test; install the signed "golden image"; load models; run the accuracy suite; record serial numbers |
| 4. **Birth certificate** | You | Automatic | Signed manifest of every software and model version, file hashes, and test results. Give the client a copy. It's a trust artifact and the audit baseline. |
| 5. Ship or hand-deliver | You | 1–3 days | Insured shipping or hand delivery (preferred in your metro); tamper-evident seals |
| 6. On-site install | You | 0.5–1 day | Rack or place it; UPS; network; TLS certificates; AD join; **egress-deny test run in front of client IT**; smoke test |
| 7. Configure workflows | You | 1–3 days (remote or on-site) | Workspaces and matters; roles; templates and schemas for their documents; import their review-sheet formats |
| 8. Train users | You | 2 × 1-hour sessions + a short admin session | Record the sessions (on their system); leave a 2-page quick-start guide |
| 9. Acceptance | Client signs | 1 hr | Checklist: works offline, logins work, workflows produce expected output on 3 sample documents, audit log records activity |
| 10. Hypercare | You | 2–4 weeks | Weekly check-in; fix friction; capture first time-savings numbers for the case study |

Typical elapsed time is **2–3 weeks when hardware is in stock**, and 6–10 weeks when a builder or distributor has short lead times. Waiting on OEM build-to-order GPU systems can take months (32–52 weeks were quoted in 2026), which is why you buy from in-stock channels (§1). Your labor per install is ~20 hours (Practice), ~40 hours (Firm), ~100 hours (Enterprise). Those are the planning assumptions in the financial model.

---

## 6. Keeping it running

### Updates and the model lifecycle

- **Quarterly release:** security patches, app updates, and (when they're better *on your accuracy tests*) new model versions
- **Signed offline bundles:** one file containing container images, model weights, and a checksum manifest, signed with your release key. The box refuses unsigned bundles.
- **Staged rollout:** your lab box first, then design partners, then everyone
- **One-command rollback**, with the previous version kept on disk
- **Critical security patches** outside the quarterly cycle when necessary

### Support model

| | Practice | Firm | Enterprise |
|---|---|---|---|
| Support hours | Business hours, email/phone | Business hours + named engineer | Extended hours + named engineer + quarterly on-site |
| Response target (outage / normal) | Next business day / 2 business days | 4 business hours / 1 business day | 2 hours / same day |
| Hardware failure | OEM next-business-day on-site warranty; you coordinate | Same, plus a loaner from your spare pool | Same, plus hot-spare parts on site |
| Check-in | Quarterly | Monthly | Monthly + quarterly business review |

**Remote access policy:** you never have standing access. When support needs to see the box, **the client starts a screen share**, and it's logged. That keeps your company out of the sensitive-data path, which makes BAAs, CMMC, and ethics questions far simpler, and it's a selling point in its own right.

### Hardware lifecycle

- 3-year OEM on-site warranty included in every quote; offer years 4–5 as an option
- Plan a **refresh at year 3–5**. It's also a natural moment to sell an upgrade tier, and it creates repeat hardware revenue (not included in the financial model).
- End-of-life: wipe per NIST SP 800-88 with a certificate of destruction for the drives

---

## 7. Site requirements to give clients

| | Practice | Firm | Enterprise | 4-GPU custom |
|---|---|---|---|---|
| Power | Any outlet | Standard 15 A outlet | Dedicated 20 A circuit recommended | 208/240 V circuit (e.g., L6-30) |
| UPS | ~1 kVA ($250–600) | ~2.2 kVA ($700–1,500) | ~2.2–3 kVA ($1,000–2,000) | 5–6 kVA online ($3–7k) |
| Cooling | None special | Ventilated room or closet | Ventilated closet; watch summer temperatures | Dedicated cooling (mini-split, ~$3–8k) |
| Noise | Silent | Quiet | Quiet (water-cooled options ≤46 dB) | Loud; server room only |
| Network | 1 GbE | 1–10 GbE | 10 GbE recommended | 10–25 GbE |

UPS and cooling cost ranges are estimates, not quotes.

---

## 8. Cloud: when and how to use it

The product runs on-prem, but the **cloud is useful for your own operations**:

| Use | Option | Cost |
|---|---|---|
| Hosted demo sandbox (**synthetic data only**) | 1× RTX PRO 6000 instance: RunPod ~$2.09/hr, AWS g7e.2xlarge ~$3.36/hr | ~$15–35/day if run only during demo hours |
| CI and model evaluation | Spot/community GPUs (Vast ~$1.48/hr for RTX PRO 6000) | Pay per run |
| Large one-off processing jobs | H100 at ~$2–4/hr (RunPod, Lambda) | Per job |

Prices from [Thunder Compute's Sept 2026 comparison](https://www.thundercompute.com/blog/nvidia-rtx-pro-6000-pricing) and [RunPod](https://www.runpod.io/gpu-models/h100-pcie).

**On-prem versus cloud break-even:** a ~$20–25k single-GPU workstation pays for itself in **8–10 months** against a comparable HIPAA-eligible AWS instance running 24×7 (~$2,450/month). Against business-hours-only cloud use (~$740/month), it takes 2.3–2.8 years. Use this in proposals for clients who are comparing against "just run it in our own Azure/AWS account". That's a legitimate middle path (a private cloud tenant with a BAA), and you can offer it as a deployment option later.

---

## 9. Security hardening checklist (per box)

- [ ] Full-disk encryption (LUKS, unlocked with TPM + PIN or a network-bound key)
- [ ] Secure Boot on; BIOS/firmware password set; USB boot disabled
- [ ] Default-deny outbound firewall; verified with a scripted egress test at install and after every update
- [ ] No default passwords; SSH keys only, restricted to the admin VLAN (or disabled in strict mode)
- [ ] Automatic security patches through the signed bundle process only
- [ ] Center for Internet Security (CIS) benchmark for Ubuntu LTS applied; deviations documented
- [ ] App: TLS everywhere; LDAP/AD with MFA where the client has it; role-based access; matter-level permissions
- [ ] Append-only audit log, exportable to the client's log collection system (SIEM)
- [ ] Encrypted local backups of configuration and indexes (the client's documents stay in their own systems)
- [ ] Annual third-party penetration test of the appliance image, once revenue allows; share the summary with prospects
