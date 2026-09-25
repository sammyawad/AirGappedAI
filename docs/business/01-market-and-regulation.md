# 01 — Market and Regulation: Who Needs This, and Why

> Research date: 2026-09-25. Legal and regulatory summaries are for business planning, **not legal advice**. Have counsel review anything you put in front of customers.

---

## 1. The thesis, stated honestly

Professionals in law, healthcare, tax, and finance want AI, but their rules make them responsible for where client data goes. Many ban AI outright, and many staff use it anyway without permission.

**Most of these rules don't actually *prohibit* cloud AI.** Cloud vendors now sign BAAs, promise no training on customer data, and hold FedRAMP authorizations (see [02](02-competition.md#4-the-honest-cloud-counter-argument)). What the rules do is impose **consent, diligence, and oversight burdens** on anything that sends data to a third party.

An appliance in the client's office removes the third party from the picture, and most of those burdens shrink with it. That's the real value proposition: **not "the cloud is illegal", but "this cuts the vendor paperwork, avoids the consent conversation, and strengthens your confidentiality position."** It doesn't replace the firm's own duties: an AI policy, training, and supervision.

### Why now

1. **Local models got good enough.** Open models like gpt-oss-120b and Qwen3.8-27B (both Apache 2.0) handle document extraction and summarization well on a single box ([04](04-infrastructure-and-logistics.md#3-models)).
2. **The hardware got small.** A 128 GB AI desktop costs $4,000–4,700 and sits on a shelf.
3. **The rules tightened in 2024–2026.** ABA Formal Opinion 512, *U.S. v. Heppner*, California SB 574, SEC Regulation S-P amendments, CMMC Phase 2, and Texas SB 1188 (all below).
4. **Unsanctioned AI use is everywhere.** 34% of professionals use AI tools their organization hasn't approved ([Thomson Reuters 2026](https://www.thomsonreuters.com/en/institute/future-of-professionals-2026/report)). 78% of AI users bring their own tools, and 80% at small and mid-size businesses ([Microsoft Work Trend Index 2024](https://www.microsoft.com/en-us/worklab/work-trend-index/ai-at-work-is-here-now-comes-the-hard-part)).

---

## 2. Segment ranking and recommendation

| Rank by regulatory pull | Segment | Why the pull exists | US count (size band) | Fit with current repo | Verdict |
|---|---|---|---|---|---|
| 1 | **Defense contractors** (CUI/ITAR) | The broadest hard-law limits on where AI can run: any cloud touching controlled unclassified information must be FedRAMP Moderate or equivalent, and CMMC Phase 2 starts **Nov 10, 2026**. Narrower limits exist elsewhere, e.g., §7216's offshore SSN rule and Texas's US-storage rule for health records. | ~220,000 companies in the defense industrial base | Low (needs new workflows) | **Test**: 10 discovery interviews before building anything |
| 2 | **CPA and tax firms** | IRC §7216 makes improper disclosure of return information a crime; the FTC Safeguards Rule treats every tax preparer as a financial institution; there's no IRS safe harbor for AI | 50,885 CPA firms with employees; **15,789 with 5+** | Medium (Financial category; needs tax forms) | **Secondary**: time-boxed pilots for the 2027 tax season |
| 3 | **Law firms** | ABA 512 consent for self-learning tools; privilege risk after *Heppner*; California SB 574 pending; Florida exempts in-house AI from consent | 156,583 firms with employees; **17,194 with 10–499 employees** | **High** (Legal + Medical extractors) | **Primary beachhead** |
| 4 | Healthcare | A BAA gives a clear cloud path, but Texas requires US-stored records, Part 2 raises the bar for addiction-treatment records, and breach costs are highest | 132,899 physician offices; 6,100 hospitals; 1,356 health centers | High (Medical extractor) | **Later**: behavioral health, hospital legal/compliance |
| 5 | RIAs and broker-dealers | Reg S-P, SEC, and FINRA allow vendors if they're overseen; the pull is diligence burden, not prohibition | 16,544 SEC-registered RIAs | Medium | Later |
| 6 | Community banks and credit unions | Heavily examined, but already depend on cloud core processors; a Sept 2026 proposal would *lighten* vendor-risk guidance | 4,313 banks; 4,214 credit unions | Medium | Later (needs SOC 2 first) |

Ranking synthesized from the sources in §3–§7. Counts from Census SUSB 2022 ([Census](https://www2.census.gov/programs-surveys/susb/tables/2022/us_state_6digitnaics_2022.xlsx)), [IAA](https://www.investmentadviser.org/wp-content/uploads/2026/06/Snapshot-2026.pdf), [FDIC](https://api.fdic.gov/banks/financials?filters=REPDTE:20260630), [NCUA](https://ncua.gov/files/publications/analysis/quarterly-data-summary-2026-Q2.pdf), [AHA](https://www.aha.org/statistics/fast-facts-us-hospitals), and [HRSA](https://data.hrsa.gov/tools/data-reporting/program-data/national).

### Why law firms first, even though they rank third on regulatory pull

- **Product fit.** The repo's Legal and Medical extractors combine into the medical-chronology workflow ([06](06-product-roadmap.md)). No other segment gets a sellable workflow that fast.
- **The pitch is crisp.** "Florida says AI that doesn't disclose to a third party doesn't need client consent. A federal judge found consumer-AI chats weren't privileged. With a box in your office, there's no third party in the loop." (*Heppner* left open how private or enterprise tools are treated, so say "strengthens your position", not "guarantees privilege".)
- **Decisions are fast at small firms.** A managing partner signs, often within 2–8 weeks. Mid-size firms take longer, typically 3–9 months with IT and security review (both estimates).
- **Channels exist.** Legal-focused IT providers, CLE, bar associations, and ILTA's startup exhibit zone ([05](05-go-to-market.md#7-channels-that-borrow-trust)).
- **Privacy concern is highest at the target size.** 54–56% of lawyers at firms with 10+ attorneys cite data privacy and security as a top AI concern, versus 24% of solos ([ABA 2024 Legal Technology Survey](https://www.lawnext.com/2025/03/aba-tech-survey-finds-growing-adoption-of-ai-in-legal-practice-with-efficiency-gains-as-primary-driver.html)).

**Why CPA firms second:** the strongest regulatory hook of the three verticals the product already covers, but **the timing is tight**. Tax season runs January to April 15, so pilots must be installed by mid-December, and the product first needs tax-form (W-2/1099/K-1) extraction. Decide by week 4: if a CPA firm commits as a design partner, build it; if not, restart the CPA track after April 15. CPA.com is also taking applications for its 2027 Startup Accelerator ([CPA.com](https://accelerator.cpa.com/)).

**Why test defense contractors:** strongest pull, and Phase 2 starts in six weeks. But no survey measures their demand for on-prem AI, the workflows differ (security documentation, proposals, technical manuals), and you'd face scrutiny of your own security. Run 10 interviews, attend CS5 (Oct 22–23, 2026, National Harbor), and talk to CMMC consultants (Registered Provider Organizations) before investing.

---

## 3. Legal

### ABA Formal Opinion 512 (July 29, 2024)

The ABA's first formal guidance on generative AI ([ABA](https://www.americanbar.org/news/abanews/aba-news-archives/2024/07/aba-issues-first-ethics-guidance-ai-tools/), [NCBE summary](https://thebarexaminer.ncbex.org/article/fall-2024/generative-artificial-intelligence-tools/)):

- **Confidentiality (Rule 1.6):** lawyers must assess the risk that information is disclosed or accessed. For **self-learning tools, informed client consent is required** before inputting information relating to the representation, and **boilerplate in an engagement letter is "not adequate."** The consent rule turns on whether a tool *learns from inputs*, not where it runs: enterprise cloud tools that don't train on customer data may not trigger it, but they still require vendor diligence. On-prem avoids both the consent question and the vendor diligence.
- **Competence (Rule 1.1):** understand what the tool can and can't do; uncritical reliance on its output is a risk.
- **Communication (Rule 1.4)** and **fees (Rule 1.5):** disclose AI use when appropriate; don't bill for learning a tool.

### State bar guidance (selected)

| State | Guidance | What it means for on-prem |
|---|---|---|
| **Florida** | Op. 24-1 (Jan 2024) | "If the use… does not involve the disclosure of confidential information to a third-party, a lawyer is not required to obtain a client's informed consent." **On-prem is exactly this case** ([Florida Bar](https://www.floridabar.org/etopinions/opinion-24-1/)) |
| **California** | Practical Guidance (Nov 2023; revised May 2026) plus **SB 574** (passed 75-0, Aug 31, 2026; the Governor must act by Sept 30) | SB 574 would bar entering confidential information into AI unless access is "restricted to the attorney and persons authorized by the attorney." If signed, it's a strong pull toward systems the firm controls ([bill text](https://leginfo.legislature.ca.gov/faces/billTextClient.xhtml?bill_id=202520260SB574), [Sullivan & Cromwell](https://www.sullcrom.com/insights/memo/2026/September/California-Legislature-Passes-Rules-Generative-AI-Use-Legal-Practitioners)). **Check whether it was signed.** |
| **Texas** | Op. 705 (Feb 2025) | The lawyer must be "reasonably satisfied that the program will not reveal confidential information" and "may need to secure client consent" ([TCLE](https://www.legalethicstexas.com/resources/opinions/opinion-705/)) |
| **Pennsylvania** | Joint Op. 2024-200 (May 2024) | AI handling confidential data must meet "strict confidentiality measures"; also notes some malpractice carriers "will not insure for AI's use" ([PDF](https://www.lawnext.com/wp-content/uploads/2024/06/Joint-Formal-Opinion-2024-200.pdf)) |
| **DC** | Op. 388 (Apr 2024) | If the provider or others can see prompts, that's "at least a red flag" ([DC Bar](https://www.dcbar.org/for-lawyers/legal-ethics/ethics-opinions-210-present/ethics-opinion-388)) |
| **North Carolina** | 2024 FEO 1 (Nov 2024) | Avoid client-specific information in public AI. **Also cautions that local servers may be as vulnerable as large vendors, or more.** Your security has to be real, not just "it's local" ([NC Bar](https://www.ncbar.gov/for-lawyers/ethics/adopted-opinions/2024-formal-ethics-opinion-1/)) |
| Kentucky | E-457 (Mar 2024) | Confidential input "may be allowable" if the provider commits in writing not to send data off-site ([KBA](https://kybar.org/Portals/0/Admin/Ethics%20Opinions/KBA%20E-457.pdf)) |
| New York, New Jersey, Oregon, Minnesota, and 20+ others | Various, 2024–2025 | Existing confidentiality rules apply; get consent or protect data ([NYC Bar 2024-5](https://www.nycbar.org/reports/formal-opinion-2024-5-generative-ai-in-the-practice-of-law/), [NJ](https://www.njcourts.gov/sites/default/files/notices/2024/01/n240125a.pdf), [OR](https://www.osbar.org/_docs/ethics/2025-205.pdf)) |

### Courts

- ***U.S. v. Heppner*** (S.D.N.Y., Judge Rakoff, Feb 10, 2026): a defendant's exchanges with a consumer AI chatbot were **not privileged and not work product**, because the provider's terms meant there was no expectation of confidentiality. The court left open how enterprise or private tools would be treated ([Debevoise](https://www.debevoisedatablog.com/2026/02/11/district-court-rules-ai-generated-documents-are-not-protected-by-privilege/), [O'Melveny](https://www.omm.com/insights/alerts-publications/sdny-first-of-its-kind-ruling-ai-generated-documents-are-not-privileged/)).
- **AI hallucination cases:** 2,078 worldwide, 1,429 of them in the US, as of Sept 25, 2026 ([Charlotin database](https://www.damiencharlotin.com/hallucinations/)). That's why every output needs page citations and human review ([06](06-product-roadmap.md#5-engineering-principles-for-this-product)).
- About 143 federal district judges have AI standing orders (secondary source, May 2026). One Court of International Trade order requires certifying that AI use didn't disclose confidential information ([order](https://www.cit.uscourts.gov/sites/cit/files/Order%20on%20Artificial%20Intelligence.pdf)).

### What clients and insurers actually require

- **Client AI restrictions are real but still rare.** Of 1,054 outside-counsel guidelines written since ChatGPT launched, only 20 (2%) mention AI: 1 bans it, 3 require prior approval, and 9 restrict client data in public tools ([Fulkerson Advisors, Sept 2026](https://www.fulkersonadvisors.com/research/ai-in-outside-counsel-guidelines)).
- 40% of professionals report clients telling them both to use AI *and* not to ([Thomson Reuters 2026](https://www.thomsonreuters.com/content/dam/ewp-m/documents/thomsonreuters/en/pdf/reports/2026-ai-in-professional-services-report.pdf)).
- **Don't lead with "your clients forbid it."** Lead with consent, privilege, and control. Ask about client restrictions in discovery calls: when they exist, they're a deal accelerator.

### Adoption and barriers

| Finding | Source |
|---|---|
| 30% of lawyers used AI in 2024, up from 11%; 46% at firms with 100+ lawyers | [ABA 2024 survey](https://www.lawnext.com/2025/03/aba-tech-survey-finds-growing-adoption-of-ai-in-legal-practice-with-efficiency-gains-as-primary-driver.html) |
| Top AI concerns: accuracy 75%, reliability 56%, **data privacy/security 47%** (54–56% at firms with 10+ lawyers) | same |
| Organization-level generative-AI use at law firms: 41% (2026) | [Thomson Reuters 2026](https://www.thomsonreuters.com/en/institute/articles/ai-in-professional-services-report-2026) |
| 42% cite "lack of demonstrable security" as a barrier to AI investment | [TR Future of Professionals 2025](https://www.thomsonreuters.com/en/insights/articles/navigating-the-concerns-of-ai) |
| **34% use AI tools their organization hasn't sanctioned**; 96% prioritize safeguarding data | [TR Future of Professionals 2026](https://www.thomsonreuters.com/en/institute/future-of-professionals-2026/report) |
| 1,374,720 active US lawyers (2025) | [ABA](https://www.americanbar.org/news/abanews/aba-news-archives/2025/12/aba-2025-profile-of-the-legal-profession-report/) |

---

## 4. CPA and tax firms

- **IRC §7216** makes knowingly or recklessly disclosing or using tax return information without authorization a **federal misdemeanor**: up to $1,000 ($100,000 if identity-theft related) and/or a year in prison. There's also a civil penalty of $250 per disclosure under §6713 ([§7216](https://www.law.cornell.edu/uscode/text/26/7216), [§6713](https://www.law.cornell.edu/uscode/text/26/6713)).
- "Disclosure" means making information known "to any person in any manner whatever." Software providers can count as "auxiliary" preparers ([Treas. Reg. 301.7216-1](https://www.law.cornell.edu/cfr/text/26/301.7216-1)).
- **Offshore processing needs prior consent, and a preparer may not obtain consent to send full SSNs offshore at all** ([301.7216-2](https://www.law.cornell.edu/cfr/text/26/301.7216-2), [301.7216-3](https://www.law.cornell.edu/cfr/text/26/301.7216-3)). Cloud AI with offshore processing or support staff is a gray area, and there's **no IRS guidance specific to AI**.
- **FTC Safeguards Rule:** tax preparers are "financial institutions". They must oversee service providers by contract, reassess them periodically, and report breaches affecting 500+ consumers within 30 days ([FTC](https://www.ftc.gov/business-guidance/resources/ftc-safeguards-rule-what-your-business-needs-know)). The IRS says every tax professional needs a **written information security plan (WISP)** ([IRS Pub. 5708](https://www.irs.gov/pub/irs-pdf/p5708.pdf)).
- **Adoption:** ~34% of tax firms use generative AI organization-wide (Thomson Reuters 2026 infographic; verify before quoting).

**The on-prem pitch:** "No disclosure to a third party, no offshore question, one less vendor in your WISP."

---

## 5. Healthcare

- **HIPAA doesn't require on-prem.** Any cloud or AI vendor handling electronic PHI is a business associate and must sign a BAA ([HHS cloud guidance](https://www.hhs.gov/hipaa/for-professionals/special-topics/health-information-technology/cloud-computing/index.html)), and major AI vendors now do. That's why healthcare ranks fourth.
- **HIPAA Security Rule update:** proposed Jan 2025. It would require AI tools touching electronic PHI to appear in the risk analysis and asset inventory. **Not final**: final action is now slated for **July 2027** ([Federal Register](https://www.federalregister.gov/documents/2025/01/06/2024-30983/hipaa-security-rule-to-strengthen-the-cybersecurity-of-electronic-protected-health-information), [HIPAA Journal](https://www.hipaajournal.com/hipaa-security-rule-update-postponed/)).
- **42 CFR Part 2** (addiction-treatment records): compliance required from **Feb 16, 2026**, with an HHS enforcement program announced Feb 13, 2026 ([HHS](https://www.hhs.gov/hipaa/part-2/index.html)). This is behavioral health's extra layer of sensitivity.
- **Texas SB 1188:** electronic health records must be **"physically maintained in the United States,"** including records held by cloud providers (storage requirement from Jan 1, 2026). Diagnostic AI use requires practitioner review and patient disclosure ([text](https://capitol.texas.gov/tlodocs/89R/billtext/html/SB01188F.htm)).
- **Other state laws:** California AB 3030 (AI-generated patient messages need a disclaimer, since Jan 2025), Texas HB 149 (disclose AI use in treatment, since Jan 2026), Illinois HB 1806 (no AI-delivered therapy).
- **Physicians:** 80%+ use AI professionally, and **86% say data-privacy assurances are important** before adopting AI ([AMA 2026](https://www.ama-assn.org/system/files/physician-ai-sentiment-report.pdf)).
- **Breach cost:** healthcare averages **$7.42M per breach**, the highest of any industry for 14 years running ([HIPAA Journal on IBM 2025](https://www.hipaajournal.com/average-cost-of-a-healthcare-data-breach/)). Breaches involving shadow AI add ~$670K ([IBM 2025](https://newsroom.ibm.com/2025-07-30-ibm-report-13-of-organizations-reported-breaches-of-ai-models-or-applications,-97-of-which-reported-lacking-proper-ai-access-controls)).

**Where to aim later:** behavioral health (Part 2), hospital legal and compliance departments, health-information departments handling records requests, and organizations whose policies forbid new PHI vendors. **Skip** practices that already run cloud EHRs and just want a scribe. Their PHI is already in a vendor cloud, and scribes are a crowded, cheap market ([02](02-competition.md#medical-clinical)).

---

## 6. RIAs, broker-dealers, banks, and credit unions

- **SEC Regulation S-P amendments:** compliance required from **Dec 3, 2025** (larger firms) and **June 3, 2026** (smaller). Every RIA needs an incident-response program, **vendor oversight**, and service providers that report breaches within 72 hours ([SEC fact sheet](https://www.sec.gov/files/34-100155-fact-sheet.pdf)).
- **SEC FY2026 exam priorities:** AI representations and policies to "monitor and/or supervise their use of AI," plus third-party vendor oversight ([SEC](https://www.sec.gov/files/2026-exam-priorities.pdf)).
- **FINRA:** Notice 24-09 says rules are technology-neutral. The 2026 oversight report adds generative-AI guidance, including keeping prompt and output logs ([FINRA](https://www.finra.org/rules-guidance/guidance/reports/2026-finra-annual-regulatory-oversight-report/gen-ai)). An on-prem audit log answers this directly.
- **NYDFS** (23 NYCRR 500 AI guidance, Oct 2024): AI-specific diligence on vendors; minimize nonpublic information in AI tools ([DFS](https://www.dfs.ny.gov/industry-guidance/industry-letters/il20241016-cyber-risks-ai-and-strategies-combat-related-risks)).
- **Counter-signal for banks:** on Sept 15, 2026, the OCC, Fed, FDIC, and NCUA proposed replacing the 2023 third-party risk guidance with lighter, risk-tailored guidance (comments due Nov 16, 2026) ([Federal Register](https://www.federalregister.gov/documents/2026/09/15/2026-18859/proposed-third-party-risk-management-guidance)).

---

## 7. Defense contractors (the segment to test)

- **CMMC dates:** the program rule took effect Dec 16, 2024. The contract (DFARS) rule took effect **Nov 10, 2025**. **Phase 2 starts Nov 10, 2026**, when third-party Level 2 certification becomes a condition of award on applicable contracts ([32 CFR 170](https://www.govinfo.gov/content/pkg/FR-2024-10-15/html/2024-22905.htm), [DFARS rule](https://www.govinfo.gov/content/pkg/FR-2025-09-10/html/2025-17359.htm)).
- **Scale:** ~220,000 defense-industrial-base companies. The DFARS rule estimates 337,968 affected entities, 68% of them small.
- **Cloud rule:** any cloud that processes, stores, or transmits CUI must be **FedRAMP Moderate or equivalent**.
- **Export control:** ITAR and EAR cloud carve-outs cover only end-to-end-encrypted data. An LLM must read plaintext, so cloud inference on controlled technical data needs a US-person-controlled environment (our analysis; confirm with export counsel).
- **The cloud alternatives exist but are gated:** Azure Government OpenAI and Microsoft 365 GCC High require eligibility validation and volume licensing ([Microsoft](https://learn.microsoft.com/en-us/office365/servicedescriptions/office-365-platform-service-description/office-365-us-government/gcc-high-and-dod)).
- **Evidence gap:** no survey measures small contractors' demand for on-prem AI. **Treat it as a hypothesis.**

---

## 8. Market size, bottom-up

Analyst reports on the "LLM market" contradict each other: one puts on-prem at 59% of revenue, another says cloud dominates. None sizes our niche. A bottom-up estimate is more useful:

| Segment | Firms in target size band | Share with a strong on-prem reason *(assumption)* | Target firms | Typical annual contract | Annual recurring revenue (ARR) opportunity |
|---|---|---|---|---|---|
| Law firms, 10–499 employees | 17,194 | 10% | ~1,700 | ~$30k | ~$52M |
| CPA firms, 5+ employees | 15,789 | 5% | ~790 | ~$18k | ~$14M |
| Physician offices, 20+ employees | 15,577 | 3% | ~470 | ~$30k | ~$14M |
| RIAs | 16,544 | 2% | ~330 | ~$18k | ~$6M |
| Banks and credit unions | 8,527 | 3% | ~255 | ~$48k | ~$12M |
| **Subtotal (excluding defense)** | | | **~3,500** | | **~$100M** |

Defense contractors could add as much again, but the demand is unproven (see §7).

**How to read this:** the shares are guesses you'll refine in customer discovery. The conclusion is robust even if they're off by 2×. **The Base plan's 46 clients by month 36 ([03](03-pricing-and-unit-economics.md)) is ~1–2% of the addressable slice.** You don't need a big market; you need a focused one.

### Demand signals and counter-signals

| Signal | Direction | Source |
|---|---|---|
| 90% of organizations see local data storage as "inherently safer" | ✅ For | [Cisco 2025](https://newsroom.cisco.com/c/r/newsroom/en/us/a/y2025/m04/cisco-2025-data-privacy-benchmark-study-privacy-landscape-grows-increasingly-complex-in-the-age-of-ai.html) |
| 27% of organizations banned GenAI at least temporarily; 48% admit entering non-public info | ✅ For | [Cisco 2024](https://newsroom.cisco.com/c/r/newsroom/en/us/a/y2024/m01/organizations-ban-use-of-generative-ai-over-data-privacy-security-cisco-study.html) |
| Vertical AI spend 2025: healthcare $1.5B, legal $650M | ✅ Budgets exist | [Menlo Ventures](https://menlovc.com/perspective/2025-the-state-of-generative-ai-in-the-enterprise/) |
| Open-source models' share of enterprise usage fell from 19% to 11% | ⚠️ Against | same |
| Deloitte 2026: the skills gap, not privacy, is the biggest AI barrier | ⚠️ Against | [Deloitte](https://www.deloitte.com/us/en/what-we-do/capabilities/applied-artificial-intelligence/content/state-of-generative-ai-in-enterprise.html) |

The counter-signals are about *large enterprises*. Small and mid-size regulated firms have less IT capacity to manage cloud-vendor diligence, which is exactly why a turnkey appliance with white-glove service fits them. The skills-gap finding also supports selling **service and finished workflows**, not just a box.

---

## 9. Ten facts for sales conversations

1. **Florida Bar Op. 24-1:** AI use that doesn't disclose confidential information to a third party doesn't require client consent. [Link](https://www.floridabar.org/etopinions/opinion-24-1/)
2. **ABA Op. 512:** self-learning AI tools require informed client consent, and boilerplate engagement-letter consent is "not adequate." [Link](https://thebarexaminer.ncbex.org/article/fall-2024/generative-artificial-intelligence-tools/)
3. ***U.S. v. Heppner*** (Feb 2026): chats with a consumer AI tool weren't privileged because the provider's terms defeated confidentiality. [Link](https://www.debevoisedatablog.com/2026/02/11/district-court-rules-ai-generated-documents-are-not-protected-by-privilege/)
4. **California SB 574** (passed 75-0) would bar confidential data in AI unless access is restricted to the attorney and authorized persons. *Check signing status before using.* [Link](https://leginfo.legislature.ca.gov/faces/billTextClient.xhtml?bill_id=202520260SB574)
5. **2,078 AI hallucination cases** in court (1,429 in the US) as of Sept 2026. Citations and review matter. [Link](https://www.damiencharlotin.com/hallucinations/)
6. **Tax preparers:** misusing return information is a federal misdemeanor, and full SSNs can't go offshore even with consent. [Link](https://www.law.cornell.edu/cfr/text/26/301.7216-3)
7. **The FTC treats every tax-prep firm as a financial institution:** a WISP and vendor oversight are required, and breaches affecting 500+ consumers must be reported within 30 days. [Link](https://www.ftc.gov/business-guidance/resources/ftc-safeguards-rule-what-your-business-needs-know)
8. **Since June 3, 2026, every SEC-registered adviser** must oversee vendors and get breach notice within 72 hours. [Link](https://www.govinfo.gov/content/pkg/FR-2024-06-03/html/2024-11116.htm)
9. **CMMC Phase 2 starts Nov 10, 2026**; any cloud touching CUI must be FedRAMP Moderate or equivalent. [Link](https://www.govinfo.gov/content/pkg/FR-2024-10-15/html/2024-22905.htm)
10. **Healthcare breaches average $7.42M**, and **86% of physicians** want data-privacy assurances before adopting AI. [IBM](https://newsroom.ibm.com/2025-07-30-ibm-report-13-of-organizations-reported-breaches-of-ai-models-or-applications,-97-of-which-reported-lacking-proper-ai-access-controls), [AMA](https://www.ama-assn.org/system/files/physician-ai-sentiment-report.pdf)

**Use them carefully:** cite the source, never overstate ("the ABA *requires* on-prem" is false), and remember that NC's opinion warns local servers can be *less* secure. Your security has to be demonstrably good.
