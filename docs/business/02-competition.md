# 02 — Competition and Pricing Benchmarks

> Research date: 2026-09-25. Prices marked **(3P)** come from third-party review or pricing sites, because the vendor doesn't publish them. Treat them as ranges, not quotes.

---

## 1. The landscape in one table

| Group | Examples | Price range | Deployment | Threat to us |
|---|---|---|---|---|
| **A. Premium vertical AI (cloud)** | Harvey, CoCounsel, Lexis+ AI, Clio Work, EvenUp, Supio, Abridge, Suki, Jump, Blue J, Basis | $100–2,000 per seat/month | Vendor cloud only | Medium. They own the "best AI" narrative, but none is air-gapped. |
| **B. Horizontal AI with compliance paperwork (cloud)** | Microsoft Copilot, ChatGPT Enterprise, Claude Enterprise, Azure OpenAI, AWS Bedrock, Google Gemini | $20–60 per seat/month, or pay per use | Cloud with BAAs, FedRAMP, no training on customer data | **High.** "Cloud is compliant enough" is the objection we'll hear most. |
| **C. Free do-it-yourself local AI** | Ollama, Open WebUI, LM Studio (free for work since July 2025), AnythingLLM, Jan, GPT4All | $0 | Local | Medium. An IT-savvy firm can build a rough version itself. |
| **D. On-prem vendors (direct competitors)** | Iternal AirgapAI (laptop), Zanus AI and eRacks (appliances), Dell AI Factory, Nutanix, H2O.ai, Cohere North, Zylon (enterprise platforms) | $697/user to $500k+ | On-prem or air-gapped | High in positioning, low in execution for our niche (below) |
| **E. MSPs selling "private AI"** | Petronella Technology Group, Lean Command, OpenClawInstall, local MSPs | $8k–35k hardware + $149–599/user/month managed | On-prem | **Partner or competitor.** They own the client relationship. |

**Where we fit:** a *managed* on-prem appliance with *finished vertical workflows* for teams of 5–300 users, starting with 10–150-attorney firms. That sits between laptop apps that run small models and enterprise platforms that need an IT department to operate.

---

## 2. Direct competitors (on-prem and air-gapped)

### Iternal Technologies: AirgapAI (the closest one)

| | |
|---|---|
| Product | Desktop app running small local models (Llama 3.2 1B/3B, Gemma, Qwen) on each user's Windows or Mac laptop |
| Price | **$35/month or $697 perpetual per user**; $1,499 with the Blockify add-on ([iternal.ai](https://iternal.ai/airgapai)) |
| Channel | **Dell partnership**: sold as the Dell-exclusive "AI Assist" bundle through Dell Services and partners, featured at CES 2026 ([iternal.ai](https://iternal.ai/ai-assist)); also Intel and Carahsoft (public sector) |
| Target | **Same verticals as us.** It has a law-firm page citing ABA Opinion 512 ([iternal.ai](https://iternal.ai/ai-for-law-firms)), plus healthcare and finance pages. |
| Limits | Each laptop runs its own small model (1B–9B class, per its product page), so work on long records is limited to what a laptop can run. Ask how it handles a shared document base, firm-wide administration, and audit trails; those aren't described on its public pages. |

**Our angle against it:** "A laptop can run a 3B model. A 900-page medical record needs a much larger long-context model working through the record in chunks, a shared, permissioned document base, and an audit trail. That needs a server."

**The name problem:** "AirgapAI" and "AirGappedAI" are nearly identical, for the same product type, sold to the same buyers. See [07](07-risks-and-compliance.md#1-the-name). **Rename before any public launch.**

### Appliance sellers

| Vendor | Offer | Price | Source |
|---|---|---|---|
| **Zanus AI** (Fort Lauderdale) | On-prem legal AI software, unlimited users | **$19,900 one-time** + server sold separately (~$20k–55k, 3P); 60-month financing | [zanusai.com](https://zanusai.com/products/ai-software-for-legal-law-firms), [aireviewzones](https://aireviewzones.com/zanus-ai-server-pricing-guide-2026/) |
| **eRacks** | Healthcare AI server with Ollama + Open WebUI + a 70B model | **From $8,995** | [eracks.com](https://eracks.com/healthcare-ai-server/) |
| **Understand Tech** | "AI-in-a-Box" air-gapped appliance | Annual subscription (price not disclosed) | [EIN Presswire](https://www.einpresswire.com/article/891084497/understand-tech-launches-ai-in-a-box-an-integrated-on-premise-enterprise-ai-appliance) |
| **ibl.ai** | Self-hosted platform inside the firm's network | ~$5k–8k/month for a 200-lawyer firm | [ibl.ai](https://ibl.ai/blog/ai-cost-math-for-law-firms-per-seat-vs-usage) |

These prove **the category exists and buyers pay for it**. Most sell a generic chat box on top of open-source parts. None we found sells finished, measured vertical workflows (for example, a medical chronology with page citations) plus white-glove local service.

### MSPs already selling private AI

| MSP | Offer | Price | Source |
|---|---|---|---|
| Petronella Technology Group (Raleigh) | DIY, MSP-managed on-prem, or hosted | Hardware $8k–12k entry, $15k–35k mid, $100k–500k enterprise | [petronellatech](https://petronellatech.com/blog/private-ai-deployment-guide-enterprise/) |
| Lean Command | "Sovereign deployment" for law firms (launched July 2026), with ABA 512 and §7216 checks | Not disclosed | [release](https://news.marketersmedia.com/on-premise-ai-for-law-firms-deployment-service-for-privileged-data-announced/89198435) |
| OpenClawInstall | Private AI agents for law firms | **$149 / $299 / $599 per user/month** | [openclawinstall](https://www.openclawinstall.ai/blog/legal-ai-pricing-2026-what-law-firms-pay/) |
| ValueStream AI | Medical-practice AI builds | $20k–90k year one (mid-tier); $60k–200k custom for 10 physicians | [valuestreamai](https://valuestreamai.com/blog/ai-cost-medical-practice-2026) |

**Implication:** MSPs are packaging do-it-yourself stacks (eRacks, for example, ships Ollama + Open WebUI). Those stacks have known limits: Open WebUI's branding clause above 50 users, no offline update pipeline, and no vertical workflows. **A white-label kit for MSPs is a better business than competing with them.** See the channel section of [05](05-go-to-market.md#7-channels-that-borrow-trust).

### Enterprise private-AI platforms (not our fight)

Dell AI Factory (no list prices; 5,000+ customers), Nutanix Enterprise AI, HPE Private Cloud AI, Red Hat AI (per-accelerator pricing), H2O.ai h2oGPTe (air-gapped option), Cohere North (priced per model instance), and Zylon/PrivateGPT (air-gapped option). These are built for enterprises with IT teams and six-figure budgets, which a 30-lawyer firm typically doesn't have. Dell is worth partnering with as a hardware supplier.

---

## 3. Premium vertical AI (cloud-only): the price umbrella

These set what buyers already believe AI is worth. **None offers an air-gapped deployment**.

### Legal

| Vendor | Price | Notes | Source |
|---|---|---|---|
| Harvey | ~$1,000–2,000/seat/month mid-market; ~20–25 seat minimum (3P) | $15.6B valuation (Sept 2026); Azure cloud | [insidelegalai](https://www.insidelegalai.com/articles/harvey-ai-2026-pricing-midsized), [Bloomberg](https://www.bloomberg.com/news/articles/2026-09-09/legal-ai-startup-harvey-hits-15-6-billion-value-with-550-million-round) |
| Thomson Reuters CoCounsel | ~$492/user/month for a 5-attorney firm; range $104–639 (3P) | Includes legal research content | [TR](https://sales.legalsolutions.thomsonreuters.com/en-us/products/cocounsel-legal/700/plans-pricing), [costbench](https://costbench.com/software/ai-legal-tools/cocounsel/) |
| Lexis+ AI / Protégé | ~$250–500/seat/month for small firms (3P) | Includes legal research content | [vaquill](https://www.vaquill.ai/blog/lexis-plus-ai-pricing) |
| Clio Work (vLex Vincent) | **$199/user/month** | Standalone for small firms since April 2026 | [LawSites](https://www.lawnext.com/2026/04/clio-work-clios-ai-workspace-is-now-available-to-solo-and-smaller-law-firms-as-a-standalone-product.html) |
| Spellbook | ~$179–500/user/month (3P) | Contract drafting in Word | [vaquill](https://www.vaquill.ai/blog/spellbook-pricing) |
| EvenUp, Supio, Eve, Filevine | Per case or per seat; $150–400/user/month (category, 3P) | Plaintiff PI focus; EvenUp valued at $2B+ | [proplaintiff](https://www.proplaintiff.ai/post/supio-pricing-guide-what-personal-injury-law-firms-should-expect-to-pay) |

**Litigation gap:** Relativity's generative AI runs only in RelativityOne (cloud), not on on-prem Relativity Server ([Relativity](https://help.relativity.com/RelativityOne/Content/Relativity/AI_Products_and_Features.htm)), and Relativity stops new Server matters in 2028 ([LawSites](https://www.lawnext.com/2025/01/putting-a-nail-in-the-coffin-of-its-on-prem-product-relativity-sets-2028-deadline-for-all-new-cases-to-move-to-the-cloud.html)). Litigation-support teams that chose on-prem on purpose are a natural audience.

### Medical-record review (the chronology market)

| Offer | Price | Source |
|---|---|---|
| AI record review SaaS (InPractice, Chartely, Medrecords AI) | **$0.04–0.10 per page** | [inpractice](https://www.inpractice.ai/medical-record-review-for-attorneys), [chartely](https://www.chartely.com/blog/medical-chronology-services-cost), [medrecords.ai](https://medrecords.ai/guides/medical-record-review-cost/) |
| EvenUp chronologies | ~$250–500 per chronology (estimate) | [tavrn](https://www.tavrn.ai/blog/medical-chronology-software) |
| Legal nurse consultant (human) | **~$2,500–5,000 per case** (3P) | [medrecords.ai](https://medrecords.ai/guides/medical-record-review-cost/) |

This is the ROI anchor for the beachhead, with one honest caveat. **If a firm is comfortable with cloud processing, per-page SaaS is cheap** ($20–50 for a 500-page record). We win only where cloud is off the table, so the right comparison is **manual review**. A firm running 20 chronologies a month at $2,500 each spends **$50,000/month** on human review. A $4,000/month appliance that handles the first pass pays for itself quickly, even if a nurse still reviews the output.

### Medical (clinical)

| Vendor | Price | Source |
|---|---|---|
| Microsoft Dragon Copilot | $159.99/user/month reseller list (Practice SKU, now retired), moving to per-encounter billing in 2026 | [dictationone](https://www.dictationone.com/Microsoft-Dragon-Copilot-Physician-Practice-Per-User-150-Monthly-Billing-12-Month-Commitment-Required-1-User.html), [Schneider](https://www.schneider.im/microsoft-dragon-copilot-price-decrease-licensing-changes/) |
| Abridge | ~$2,500+/clinician/year (3P) | [veroscribe](https://www.veroscribe.com/blog/abridge-review-2026) |
| Suki / Ambience | $233–399/provider/month (3P) | [scribing.io](https://www.scribing.io/blog/suki-ai-pricing-breakdown), [DeepCura](https://www.deepcura.com/resources/ambience-healthcare-review) |
| Freed | **$39–119/clinician/month**, with BAA | [getfreed.ai](https://www.getfreed.ai/pricing) |

**Don't compete on ambient scribing.** It's crowded, cloud-native, EHR-integrated, and prices are falling to $39. The medical opportunity for us is document work: summarization, referral and prior-auth letters, and record review in settings where records can't go out (behavioral health, hospital legal, research).

### Financial and accounting

| Vendor | Price | Source |
|---|---|---|
| Jump (RIAs) | $100/advisor/month (~$80 billed annually) | [jump.ai](https://jump.ai/pricing) |
| Zocks (RIAs) | ~$80–130/user/month (unverified); prices falling toward $50 | [InvestmentNews](https://www.investmentnews.com/advisor-tech/is-50-the-new-120-price-compression-comes-to-ai-notetakers/264773) |
| Blue J (tax research) | **$1,498/user/year** | [bluej.com](https://www.bluej.com/pricing) |
| TaxGPT | $99–299/user/month (3P) | [curatesuite](https://curatesuite.com/accounting/tools/taxgpt) |
| Basis, Black Ore (CPA automation) | Enterprise, by quote | [SiliconANGLE](https://siliconangle.com/2026/02/24/ai-accounting-startup-basis-secures-100m-1-15b-valuation-firms-adopt-agent-based-workflows/) |
| Bank/credit union AI | Delivered through core processors (Fiserv, FIS, Jack Henry), all cloud; consulting deployments run "low-to-mid six figures" | [CCG Catalyst](https://www.ccgcatalyst.com/thought-leadership/research-snapshot/sector-spotlight-ai-agents-and-connectors-for-banks-and-credit-unions/), [Boldr](https://getboldr.ai/insights/ai-consulting-firms-for-community-and-regional-banks-and-credit-unions) |

---

## 4. The honest cloud counter-argument

The biggest competitor isn't another on-prem vendor. It's the belief that **cloud AI is now compliant enough**, and for many uses, it is:

| Provider | What it guarantees today | Source |
|---|---|---|
| Azure OpenAI / Microsoft Foundry | No training on customer prompts, not shared with OpenAI; abuse-monitoring opt-out for approved customers; FedRAMP High; IL2–IL6 | [Microsoft](https://learn.microsoft.com/en-us/azure/ai-foundry/responsible-ai/openai/data-privacy) |
| Microsoft 365 Copilot | No training on customer data; covered by Microsoft's HIPAA BAA | [Microsoft](https://learn.microsoft.com/en-us/copilot/microsoft-365/microsoft-365-copilot-privacy) |
| AWS Bedrock | HIPAA-eligible; FedRAMP High in GovCloud | [AWS](https://aws.amazon.com/bedrock/security-compliance/) |
| Google Gemini / Vertex | Covered by Google's BAA; Gemini available on air-gapped Google Distributed Cloud via Dell | [Google](https://cloud.google.com/security/compliance/hipaa) |
| OpenAI API | No training on API data; zero data retention on approval; BAA available | [OpenAI](https://developers.openai.com/api/docs/guides/your-data) |
| Anthropic Claude | BAA covers Claude Enterprise and the API (with exclusions); Claude for Government is FedRAMP High | [Anthropic](https://privacy.claude.com/en/articles/8114513-business-associate-agreements-baa-for-commercial-customers) |

### Who still genuinely needs or prefers on-prem

Sell to these buyers, and don't waste cycles arguing with the rest:

1. **Lawyers who want to avoid the consent and privilege questions.** ABA Op. 512 requires informed consent for self-learning tools. Florida's bar says AI that doesn't disclose to a third party needs no consent. *U.S. v. Heppner* (Feb 2026) held that consumer-AI chats weren't privileged. California SB 574, if signed, restricts confidential data to systems where access is limited to the attorney and people they authorize. See [01](01-market-and-regulation.md#3-legal).
2. **Controlled Unclassified Information (CUI) or export-controlled (ITAR) data**: defense contractors, and the law and CPA firms that serve them. Any cloud touching CUI must be FedRAMP Moderate or equivalent, and CMMC Phase 2 starts Nov 10, 2026.
3. **Tax return data**: preparers who don't want to manage IRC §7216 disclosure consent or offshore-processing questions for cloud AI.
4. **Contractual prohibitions**: outside-counsel guidelines, protective orders, or data-use agreements that restrict third-party AI. These are still rare (about 2% of outside-counsel guidelines mention AI), but decisive where they exist.
5. **Firms whose leadership simply won't allow it.** This is common among senior partners, and it's a legitimate preference, not something to argue with.
6. **Cost at scale versus per-seat tools**: a flat monthly price with no per-seat fees beats $200–500 per seat as a firm grows (see [03](03-pricing-and-unit-economics.md#how-the-price-compares) for all-in math).
7. **Offline or low-connectivity sites**: courtrooms, rural clinics, field offices.
8. **Retention and legal-hold control**: logs held by any third party can be subject to subpoenas or preservation orders the firm doesn't control, while logs on the firm's own box follow the firm's own retention and legal-hold policy.

The pitch never says "the cloud is unsafe". It says *"for the documents you or your clients won't put in anyone's cloud, here's AI that never leaves the building."*

---

## 5. Battlecards

| When they say… | They're comparing us to | Our answer |
|---|---|---|
| "Harvey / CoCounsel does this" | Premium legal AI | "They're excellent for legal research. This is for the confidential files you can't send to their cloud, at a flat price with no seat minimums." |
| "We have Copilot" | Horizontal cloud AI | "Keep it for email and Word. Use this for claim files, medical records, and client financials." |
| "AirgapAI is $697 a user" | Laptop AI | "It runs small models on each laptop. Ask how it handles a 900-page record, a shared document base, and a firm-wide audit trail." |
| "Our IT guy can set up Ollama" | Free DIY | "He can. Then he owns security, patching, model updates, AD integration, audit logs, accuracy testing, and support at 2 a.m. Compare that with what his time costs." |
| "Our MSP offered a private AI box" | MSP DIY | "Great, let's work with them. We supply the AI layer and workflows; they keep the relationship and margin." |
| "Zanus is a one-time purchase" | Appliance vendor | "Ask what's included after year one: model upgrades, security patches, support. Models improve every quarter. We ship tested upgrades, and you can cancel at renewal." |

---

## 6. Pricing benchmarks summary

| Category | Low | Typical | High |
|---|---|---|---|
| Legal AI (per seat/month) | $39–59 (Clio Manage AI, 3P) | $199–500 (Clio Work, CoCounsel, Lexis) | $1,000–2,000 (Harvey mid-market, 3P) |
| Medical chronologies | $0.04–0.05/page | $0.10/page; ~$250–500 per chronology | $2,500–5,000 per case (human nurse review) |
| Ambient scribes (per clinician/month) | $39 (Freed) | $119–400 | ~$605 (Dragon Copilot Flex, 3P) |
| RIA meeting AI (per advisor/month) | $40–80 | $80–130 | $100+ with add-ons |
| Local AI app (per user) | $0 (Jan, GPT4All, LM Studio) | $149/year (Msty) | $697 perpetual (AirgapAI) |
| On-prem appliance (one-time) | $8,995 (eRacks) | $8k–35k (MSP ranges) | $19.9k software + $20k–55k server (Zanus) |
| Managed or self-hosted private AI (recurring) | ~$25–40/user equivalent (ibl.ai: $5k–8k/month flat for 200 lawyers) | $149–299/user/month (OpenClawInstall) | $599/user/month (OpenClawInstall top tier) |

**Takeaway for our pricing** (details in [03](03-pricing-and-unit-economics.md)): the subscription works out to **~$57–125 per user per month**, or **~$108–200 all-in in year one** once hardware and setup are included. That puts us at the low end of premium legal AI ($199–500) in year one and well below it afterward. We sit above generic copilots ($20–60) and below per-user managed private AI ($149–599), but above large-firm self-hosted platforms like ibl.ai (~$25–40 per user at 200 lawyers), so the Enterprise tier needs a sharper value story or volume pricing. For the chronology workflow, the comparison with human review ($2,500–5,000 per case) is the strongest ROI story.
