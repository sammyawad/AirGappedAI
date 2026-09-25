# Business Strategy: Private AI for Law, Medical, and Financial Firms

> Prepared 2026-09-25 from four research tracks (hardware and models, competitors, regulation, go-to-market) and a hands-on review of this repo.
> Every number links to a source in the detailed docs, or is marked as an estimate. Nothing here is legal advice.

---

## The answer on one page

**What to sell:** a **private AI server installed in the client's office** that reads their documents and works with the internet unplugged. Staff get summaries, extracted data, medical chronologies, and answers, each citing the source page. It comes with a **flat monthly subscription** covering updates, support, and new workflows. No per-seat fees.

**Who to sell to first:**
1. **Primary:** litigation law firms with 10–150 attorneys that handle medical records: insurance defense, med-mal, workers' comp, and PI. The repo's Medical + Legal extractors combine into the killer workflow, the **medical chronology with page citations**.
2. **Secondary:** CPA and tax firms. IRC §7216 makes improper disclosure of return data a crime, so the pull is strong. The timing is tight: decide by week 4 whether a CPA firm commits as a design partner. If one does, build tax-form extraction and install by mid-December. If not, restart the CPA track after April 15.
3. **Test:** defense contractors, whose regulatory pull is strongest (CMMC Phase 2 starts Nov 10, 2026). Run 10 discovery interviews before building anything for them.

Healthcare providers, RIAs, and banks come later. Cloud AI with a signed BAA or vendor oversight is a workable option for most of them ([01](01-market-and-regulation.md)).

**How much to charge:**

| | Practice (5–20 users) | Firm (20–75) | Enterprise (75–300) |
|---|---|---|---|
| Hardware (cost + 15%) | ~$6,300 | ~$25,700 | ~$66,700 |
| Setup & onboarding | $4,500 | $12,000 | $25,000 |
| **Subscription** | **$1,500/mo** | **$4,000/mo** | **$8,500/mo** |
| Client's year-one total | ~$28.8k | ~$85.7k | ~$193.7k |
| Per user, year one, all-in (at 12 / 40 / 150 users) | ~$200/mo | ~$178/mo | ~$108/mo |
| Per user, from year two (subscription only) | ~$125/mo | ~$100/mo | ~$57/mo |

For comparison, cloud legal AI costs **$199–500 per user/month**, and Harvey reportedly $1,000+ ([02](02-competition.md)). All-in, we're at the low end of that range in year one and well below it from year two.

**Margins:**
- Hardware is a thin pass-through (~13% gross margin), because 2026 memory shortages doubled GPU prices ([04](04-infrastructure-and-logistics.md)).
- Setup covers install labor.
- **Subscriptions run 82–86% gross margin.**
- A client's first year blends to **56–62%**. By Year 3, **80% of gross profit is recurring** ([03](03-pricing-and-unit-economics.md)).

**How much money it takes:**
- **Base case:** ~$287k to reach sustained profitability in **month 23**, ending month 36 with **46 clients and $1.78M in annual recurring revenue (ARR)**.
- **About 80% of that $287k (~$228k) is founder pay.** With no founder salaries, the business needs only **~$59k**, because clients pay for hardware in full on order and setup fees fund installs.
- If 30% of clients come through IT-partner resellers at 25% off, the Base case needs ~$318k and breaks even in month 29 ([03](03-pricing-and-unit-economics.md#7-what-moves-the-numbers-base-case-sensitivities)).
- **Upside:** $126k needed, $2.97M ARR. **Conservative:** $640k needed if you don't cut costs, which you should.

**How to win with no reputation:**
- **The Unplugged Demo.** Pull the network cable in the prospect's conference room and run their documents.
- **Paid design-partner pilots.** 50% off year one in exchange for case studies.
- **Borrow trust** from IT providers (MSPs), CLE webinars, and startup programs (ILTA Startup Hub, CPA.com Accelerator).
- **Turn "startup risk" into a pitch:** *"You own the box. If we vanish, it keeps working."*

Cold email alone won't do it. Legal, healthcare, and finance reply to about **0.6%** of cold emails ([05](05-go-to-market.md#9-funnel-math)).

**What to do first:**
1. **Rename.** "AirgapAI" is already sold by Iternal Technologies, through Dell, to these same industries, and "AirGappedAI" is likely unregistrable anyway ([07](07-risks-and-compliance.md#1-the-name)).
2. **Close the product gaps.** Add PDF/OCR upload, a web UI, page citations, and a modern model ([06](06-product-roadmap.md)).
3. **Measure accuracy on test documents before any pilot**, and build the demo box.
4. **Sign 2–3 design partners.**

---

## What's in the repo today

A working .NET 8 prototype (~300 lines) that sends text to a local model and returns structured JSON for Medical, Legal, and Financial documents, with a "needs human review" flag. It builds and its tests pass. Several verified issues matter most for a demo:
- Common model output (plain numbers, lists, JSON wrapped in code fences) fails to parse. Those documents come back with HTTP 200, flagged for manual review instead of extracted, and nothing is logged.
- Long documents get silently truncated.
- Bad input produces 500 errors.
- There's no UI, document upload, or authentication.

The design is the right starting point. The full assessment and roadmap are in [06](06-product-roadmap.md).

---

## Documents

| Doc | What's in it |
|---|---|
| [01 — Market & Regulation](01-market-and-regulation.md) | Why each segment can or can't use cloud AI (ABA 512, *Heppner*, CA SB 574, IRC §7216, HIPAA, Reg S-P, CMMC), segment ranking, bottom-up market size, 10 sales facts |
| [02 — Competition](02-competition.md) | Cloud and on-prem competitors with prices, the honest cloud counter-argument, battlecards, pricing benchmarks |
| [03 — Pricing & Unit Economics](03-pricing-and-unit-economics.md) | Price list, margins per client, 3-year scenarios, sensitivities, partner economics, client ROI |
| [04 — Infrastructure & Logistics](04-infrastructure-and-logistics.md) | Hardware tiers and 2026 prices, models and licenses, serving stack, order-to-install runbook, updates, support, site requirements |
| [05 — Go-to-Market](05-go-to-market.md) | Positioning, landing page copy, the demo, design partners, prospect list sources, outreach templates, MSP and CLE channels, event calendar, funnel math, 90-day plan |
| [06 — Product Roadmap](06-product-roadmap.md) | What's built, verified issues with file and line references, gaps to a sellable product, phased roadmap |
| [07 — Risks & Compliance](07-risks-and-compliance.md) | The naming problem, safe marketing claims, contracts, security posture, licensing, insurance, risk register |
| [financial-model.xlsx](financial-model.xlsx) | Editable model: assumptions, hardware bill of materials, sales plan, operating costs, 36-month projection, unit economics, dashboard, benchmarks |
| [prospect-list-template.csv](prospect-list-template.csv) | CRM import template for the target list |

---

## The next 90 days

This assumes one founder building full-time and one selling full-time. If you're splitting time, stretch it by ~50%. **Marketing only ever shows features that have shipped.**

| Weeks | Product | Go-to-market |
|---|---|---|
| 1–2 | Fix verified bugs; structured JSON output; config-driven models; modern model | New name and clearance; LLC; MSA, BAA, and pilot agreement; NVIDIA Inception; start ~15 discovery calls (law, CPA, and 3–5 defense contractors) |
| 3–4 | PDF/OCR upload; web UI with review queue; synthetic demo data; accuracy test set | Landing page v1 (only shipped features); first 300 prospects; sending domain; **CPA go/no-go**: build tax forms only if a CPA design partner commits |
| 5–6 | Medical chronology v1 with page citations, measured on the test set | Record the 2-minute video; warm intros; approach 3 local MSPs |
| 7–8 | Portable demo box; offline installer; tax-form extraction (only if CPA is go) | 10+ Unplugged Demos; CLE webinar pitch; ILTA and CPA.com applications |
| 9–10 | Login (LDAP/AD), audit log, admin page; accuracy check on each pilot's sample documents | Sign 2–3 design partners; pilots start once accuracy on their documents is measured |
| 11–13 | Chat over documents; fix pilot feedback | Landing page v2 adds login and audit-log claims; steady outreach; capture time-savings data; defense go/no-go |

Details in [05 §10](05-go-to-market.md#10-first-90-days) and [06 §4](06-product-roadmap.md#4-roadmap).

---

## Caveats

- **Prices move fast.** GPUs and memory-heavy hardware rose ~20–100% over the past 18 months. Re-quote hardware before every proposal.
- **Estimates are marked as estimates.** The riskiest ones: customer acquisition cost, support hours per client, sales-cycle length, and the share of each segment with a real on-prem need. Replace them with your own data from the first pilots.
- **Legal and regulatory summaries are for planning.** Check the status of pending items, especially **California SB 574** (the Governor's deadline is Sept 30, 2026), before using them in sales.
