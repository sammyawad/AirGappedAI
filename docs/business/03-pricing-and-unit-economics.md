# 03 — Pricing, Margins, and "How Much?"

> All figures come from [`financial-model.xlsx`](financial-model.xlsx) (Base scenario unless noted). Change the blue input cells in the workbook and everything recalculates.
> Hardware costs are September 2026 prices ([04](04-infrastructure-and-logistics.md)); competitor prices are in [02](02-competition.md).

---

## 1. The short answer

| Question | Answer |
|---|---|
| **What do we charge?** | Hardware at cost + 15%, a one-time setup fee of **$4.5k–25k**, and a flat subscription of **$1,500 / $4,000 / $8,500 per month** by tier, with no per-seat fees |
| **What does a client pay in year one?** | **~$29k** (small practice), **~$86k** (mid-size firm), **~$194k** (large firm) at list price |
| **What do we keep?** | **82–86% gross margin on subscriptions**, ~24–29% on setup plus hardware, and **56–62% blended in a client's first year** |
| **What does it cost us to deliver?** | A client's hardware costs us **$5.5k–58k** (passed through), plus **20–100 hours** of install labor and **2.5–12 hours a month** of support |
| **How much money do we need?** | Base case: **~$287k to reach sustained profitability in month 23.** Nearly all of that is founder pay. **With no founder salaries, the business needs only ~$59k.** |
| **What could it become?** | Base case at month 36: **46 clients, $1.78M annual recurring revenue (ARR), $2.19M Year-3 revenue, $349k Year-3 EBITDA.** Upside: $2.97M ARR. Conservative: $0.97M ARR. |

---

## 2. Pricing model

This follows the **appliance + subscription** model that security and backup vendors proved out:

- **Datto** sold its backup appliances *below cost* (−25% gross margin) and made 84% on subscriptions ([10-K](https://www.sec.gov/Archives/edgar/data/1724570/000172457022000011/msp-20211231.htm)).
- **Fortinet** makes 87% on services ([10-K](https://www.sec.gov/Archives/edgar/data/1262039/000126203926000007/ftnt-20251231.htm)).
- IT resellers like **CDW** make ~22% on hardware resale ([SEC](https://data.sec.gov/api/xbrl/companyfacts/CIK0001402057.json)).

The box is how you win the client. The subscription is the business.

| Component | How it's priced | Why |
|---|---|---|
| **Hardware** | Cost + 15%, quoted valid for 7–14 days, deposit on order | Clients can price-check a DGX Spark. Prices swing monthly in 2026 ([04](04-infrastructure-and-logistics.md#1-the-2026-hardware-reality-memory-prices-doubled)). The markup covers procurement, burn-in, imaging, and warranty handling, not profit. |
| **Setup & onboarding** | Fixed fee per tier | Pays for your install labor up front, and signals the service is real |
| **Subscription** | **Flat monthly per tier, unlimited users within the tier's capacity** | Per-seat pricing punishes adoption. A flat fee is easy to approve and is the clearest contrast with cloud tools. |
| **Pilot** | Paid, 30–45 days, credited toward setup | Free pilots attract tire-kickers. A paid pilot proves intent. |

### How the price compares

| Option | Effective price |
|---|---|
| Cloud legal AI | **$199–500 per user/month** (Clio Work, CoCounsel, Lexis) |
| Harvey | ~$1,000–2,000 per user/month (mid-market, third-party estimate) |
| Managed private AI (OpenClawInstall) | $149–599 per user/month |
| Laptop AI (Iternal AirgapAI) | $697 per user, one-time; small models only |
| **Us** | **~$57–125 per user/month equivalent** (Practice $125 at 12 users; Firm $100 at 40; Enterprise $57 at 150) |

That places us below premium cloud AI, near managed private-AI offers, and well above "free" DIY. Cheap enough to be an easy yes; expensive enough to be taken seriously.

---

## 3. Launch price list

| | **Practice** | **Firm** | **Enterprise** |
|---|---|---|---|
| Team size | 5–20 | 20–75 | 75–300 |
| Box | GB10 desktop, 128 GB | 1× RTX PRO 6000 workstation | 2× RTX PRO 6000 tower |
| Hardware price (cost + 15%) | ~$6,300 | ~$25,700 | ~$66,700 |
| Setup & onboarding (one-time) | $4,500 | $12,000 | $25,000 |
| **Subscription** | **$1,500/month** | **$4,000/month** | **$8,500/month** |
| **Year-1 total** | **~$28,800** | **~$85,700** | **~$193,700** |
| Year 2 onward | $18,000/year | $48,000/year | $102,000/year |
| Paid pilot (credited on purchase) | $2,500 | $5,000 | $10,000 |

**Terms:**
- 12-month minimum after the pilot, then annual renewal.
- **10% discount for annual prepay** (better cash flow, lower churn).
- Design partners get **50% off year one** plus a 3-year price lock.
- Hardware quotes are valid for 7–14 days, with a 50–100% deposit on order.
- Clients who want to buy hardware directly from Dell or their MSP can. You charge the same setup and subscription and specify the configuration (see §9).

### What the subscription includes

- Software license and all standard workflows (extraction, summarization, chronology, document chat)
- Quarterly signed update bundles: security patches, app updates, and model upgrades that beat the current model on your accuracy tests
- Support per tier (business hours → named engineer → extended hours with quarterly on-site; see [04](04-infrastructure-and-logistics.md#support-model))
- Hardware warranty coordination with the manufacturer (the 3-year on-site warranty is in the hardware price)
- **Compliance pack:** security whitepaper, architecture and data-flow diagrams, ABA 512 / HIPAA / §7216 / Reg S-P mapping, and inputs for their risk analysis and written information security plan (WISP)
- Onboarding training, plus refresher sessions for new staff

### Add-ons (services revenue, not in the model, so pure upside)

| Add-on | Price guidance |
|---|---|
| Custom workflow (their forms, schemas, review sheets) | $7,500–25,000 fixed fee |
| Additional on-site day | $1,500/day |
| Second box for high availability | Hardware + 40% of the subscription |
| Premium 24×7 support | +25% of the subscription |
| AI policy and staff training workshop | $2,500 per session |
| Extended warranty (years 4–5) | Cost + 15% |
| Hardware refresh (year 3–5) | New hardware + reduced setup fee |

---

## 4. Unit economics per client

| Per client (list price) | Practice | Firm | Enterprise |
|---|---|---|---|
| One-time revenue (hardware + setup) | $10,824 | $37,677 | $91,700 |
| One-time cost (hardware + install labor + travel) | $7,699 | $26,828 | $69,500 |
| **One-time gross profit** | **$3,125** (29%) | **$10,849** (29%) | **$22,200** (24%) |
| Subscription | $1,500/mo | $4,000/mo | $8,500/mo |
| Support labor + recurring cost | $275/mo | $550/mo | $1,330/mo |
| **Subscription gross margin** | **82%** | **86%** | **84%** |
| Year-1 revenue | $28,824 | $85,677 | $193,700 |
| Year-1 gross profit | $17,825 (62%) | $52,249 (61%) | $108,240 (56%) |
| Annual gross profit, year 2 onward | $14,700 | $41,400 | $86,040 |
| Lifetime gross profit (5-year cap, 10% churn) | $76,625 | $217,849 | $452,400 |
| Assumed cost to acquire (CAC) | $6,000 | $12,000 | $25,000 |
| **Lifetime profit ÷ CAC** | **12.8×** | **18.2×** | **18.1×** |
| Clients one support engineer can carry | ~47 | ~23 | ~10 |

**Reading this honestly:**
- **Delivery labor is costed at $90/hour** (a paid engineer), even while founders do it, so these margins hold after you hire.
- **CAC is the weakest number.** It's an estimate, and early deals will cost more in founder time. Even at 3× the assumed CAC, lifetime profit is still 4–6× acquisition cost. Track real CAC from the first deal.
- **Support hours are the hidden risk.** If clients need twice the assumed support, Year-3 EBITDA falls ~44% (see §7). Invest early in the admin page, self-service docs, and reliable updates.

---

## 5. Where the profit comes from (Base case)

| Gross profit | Year 1 | Year 2 | Year 3 |
|---|---|---|---|
| Hardware (cost + 15%) | $9k | $39k | $84k |
| Setup & onboarding | $22k | $84k | $175k |
| **Subscriptions** | **$27k** | **$351k** | **$1,056k** |
| Total gross profit | $58k | $474k | $1,316k |
| Subscription share | 46% | 74% | **80%** |

By Year 3, **80% of gross profit is recurring**. That's the number that makes the business durable, and valuable if you ever raise money or sell.

---

## 6. Three-year projection

Scenarios differ only in how many clients sign ([`Sales Plan`](financial-model.xlsx) sheet). Hires start automatically when active clients reach set thresholds (engineer at 5, sales/partner manager at 8, second engineer at 25, customer success at 40).

| | Conservative | **Base** | Upside |
|---|---|---|---|
| New clients (Y1 / Y2 / Y3) | 3 / 9 / 17 | **5 / 16 / 30** | 10 / 27 / 43 |
| Active clients at month 36 | 26 | **46** | 72 |
| Revenue: Year 1 | $72k | **$143k** | $378k |
| Revenue: Year 2 | $425k | **$857k** | $1.69M |
| Revenue: Year 3 | $1.18M | **$2.19M** | $3.60M |
| Gross margin, Year 3 | 59% | **60%** | 62% |
| EBITDA: Year 1 / 2 / 3 | −$140k / −$287k / −$146k | **−$109k / −$139k / +$349k** | −$54k / +$238k / +$1.16M |
| **ARR at month 36** | $0.97M | **$1.78M** | $2.97M |
| Sustained break-even (month EBITDA turns positive for good) | Month 34 | **Month 23** | Month 16 |
| **Capital needed** (starting from $0) | $640k | **$287k** | $126k |

**Operating costs assumed** (Base; [`Opex Plan`](financial-model.xlsx) sheet):
- **Founder pay:** 2 founders at $3k/month each in Year 1, $8k in Year 2, $11k in Year 3.
- **Other opex:** tools $10k → $30k/year; insurance $4k → $14k; legal and accounting $15–20k; security $9k (Year 1) → $37–45k (SOC 2 in Years 2–3); marketing and events $15k → $70k; travel $12k → $36k; 10% contingency.
- **Demo and pilot hardware:** $36k over the first 13 months.

**The Conservative column is a warning, not a forecast.** It assumes you keep spending as if sales were on plan. If sales track Conservative after two quarters, freeze founder raises, defer SOC 2 and booths, and the capital need falls sharply.

### Where the capital goes

| Variant | Capital needed | Sustained break-even |
|---|---|---|
| Base (founders paid $72k → $192k → $264k) | $287k | Month 23 |
| Founders unpaid in Year 1 only | $192k | Month 23 |
| **No founder pay at all** | **$59k** | **Month 19** |

**The business itself is nearly self-funding.** Client deposits cover hardware, setup fees cover installs, and subscription margins cover overhead by around month 19. The real question behind "how much" is **how long the founders can go on reduced pay.** Options, roughly from least to most dilutive:
- Personal savings, or keeping part-time consulting income in Year 1.
- Customer prepayments (annual prepay, paid pilots).
- An SBA or bank loan against contracted recurring revenue (later).
- Grants: SBIR/STTR are open, and AFWERX topics are relevant if you pursue the defense segment.
- A small pre-seed round.

---

## 7. What moves the numbers (Base case sensitivities)

| Change one thing | Capital needed | Sustained break-even | Year-3 EBITDA | ARR at month 36 |
|---|---|---|---|---|
| Base (as built) | $287k | Month 23 | $349k | $1.78M |
| **Subscription prices +20%** | $243k | Month 20 | **$599k** | $2.14M |
| **Subscription prices −20%** | $406k | Month 31 | **$100k** | $1.42M |
| Support hours doubled | $343k | Month 30 | $195k | $1.78M |
| Churn 20%/year instead of 10% | $302k | Month 25 | $296k | $1.62M |
| No design-partner discount | $272k | Month 23 | $349k | $1.78M |
| Founders unpaid in Year 1 | $192k | Month 23 | $349k | $1.78M |

**Lessons:**
1. **Price is the biggest lever.** A 20% price cut costs more than doubling churn. Don't compete on price; you're already well below cloud per-seat tools.
2. **Support efficiency is second.** Every support hour you automate away is margin, and "the box just works" is also the product.
3. **Design-partner discounts are cheap.** Giving away 50% of a few first-year subscriptions barely moves the outcome, and buys the case studies you can't get any other way.

---

## 8. Partner (MSP) economics, Firm tier example

| Route | You receive | Your subscription gross profit | Cost to acquire |
|---|---|---|---|
| Direct | $4,000/month | $3,450/month (86%) | ~$12,000 (your time, travel, pilot) |
| Referral partner (12.5% of first-year contract value, excluding hardware) | $4,000/month | $3,450/month | **$7,500 one-time**, cheaper than selling direct |
| Reseller partner (25% off the subscription; MSP handles tier-1 support; MSP keeps the hardware margin) | $3,000/month | ~$2,585/month (86% of net; your support drops to ~3.5 hours/month) | Near zero for you |

Partner deals earn less per client but cost little to acquire and scale without adding salespeople. **A referral fee is cheaper than your own CAC.** Pay it happily.

---

## 9. If clients buy hardware directly

| | Resell hardware (Base) | Client buys direct |
|---|---|---|
| Year-3 revenue | $2.19M | $1.55M |
| Year-3 gross margin | 60% | 80% |
| Year-3 EBITDA | $349k | $266k |
| Capital needed | $287k | $332k |
| Sustained break-even | Month 23 | Month 26 |

Reselling adds ~$84k of Year-3 gross profit and control over the exact configuration. Direct purchase avoids sales-tax, reseller, and inventory complexity. **Recommendation:** resell by default when you can collect a deposit. Let larger clients buy direct from Dell or their MSP when their procurement prefers it, and charge the same setup and subscription.

---

## 10. The client's return on investment

**Simplest framing:** at a loaded staff cost of ~$60/hour, **the subscription pays for itself if it saves:**

| Tier | Annual subscription | Hours saved to break even | Per week |
|---|---|---|---|
| Practice | $18,000 | 300 hours/year | ~6 hours/week across the whole office |
| Firm | $48,000 | 800 hours/year | ~15 hours/week, or ~23 minutes per person for 40 staff |
| Enterprise | $102,000 | 1,700 hours/year | ~33 hours/week, or ~13 minutes per person for 150 staff |

**Worked example: litigation firm (Firm tier, 40 staff, 20 medical chronologies a month).**
- **If it outsources chronologies** to legal nurse consultants at ~$2,500–5,000 per case ([medrecords.ai](https://medrecords.ai/guides/medical-record-review-cost/)): replacing just 2 outsourced reviews a month covers the subscription.
- **If it does them in-house:** at 12 paralegal hours × $45 loaded per chronology (illustrative), halving that time saves ~$5,400/month, before counting other uses across the firm or the extra cases the freed-up capacity can take.
- **The hardware** (~$25.7k) is typically deductible in year one under Section 179 / 100% bonus depreciation ([05](05-go-to-market.md#make-the-hardware-easy-to-buy)).
- **Compared with per-seat cloud:** 40 users × $199/month (Clio Work) = $7,960/month versus $4,000 flat, and nothing leaves the building.

Use the client's own numbers in every proposal. The breakeven-hours framing works even when you don't know them.

---

## 11. Pricing rules for a startup with no reputation

1. **Don't underprice.** Small firms read a low price as risk. At roughly 20–60% of cloud per-seat prices you're already the value option.
2. **Publish "starting at" prices** on the website. Buyers in these professions hate "call for pricing", and it filters out bad-fit leads.
3. **Discount the first year, never the list price.** Design partners get 50% off year one, then pay list.
4. **Always charge for pilots,** and credit the fee toward purchase.
5. **Always collect hardware deposits.** Never finance a client's hardware from your own cash.
6. **Raise prices 10–20% for new clients** once you have 5 case studies, and grandfather existing clients.
7. **Sell annual prepay.** 10% off in exchange for 12 months of cash up front is the cheapest financing you'll find.
