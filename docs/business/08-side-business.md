# 08 — Doing This as a Side Business

> What changes if one person runs this alongside a day job: the money, the hours, and the rules that keep it manageable.
> Numbers come from [`financial-model-side-business.xlsx`](financial-model-side-business.xlsx). It's the same model as the full-time plan with side-business inputs, and every assumption is editable.

---

## 1. Short answer

**Yes, it's doable on the side, with limits.**
- Sell only the two smaller tiers (Practice and Firm), in one metro, with one workflow (the medical chronology).
- Expect **~15 hours a week in year one** (mostly building the product), rising to **~20–25 by year three**.
- Around **10–15 clients**, the workload outgrows a day job. That's the point to either go full-time or hand the field work to an IT partner.

### What it could earn (profit to you, before tax)

| | Conservative | **Base** | Upside |
|---|---|---|---|
| New clients (Year 1 / 2 / 3) | 1 / 4 / 5 | **2 / 6 / 7** | 4 / 10 / 15 |
| Active clients at month 36 | ~9 | **~13** | ~26 |
| Revenue (Year 1 / 2 / 3) | $12k / $179k / $307k | **$56k / $257k / $472k** | $116k / $491k / $977k |
| **Profit to you (Year 1 / 2 / 3)** | −$31k / $75k / $185k | **−$11k / $140k / $317k** | $19k / $312k / $697k |
| Your hours per week (Year 1 / 2 / 3) | 12 / 15 / 20 | **14 / 19 / 25** | 17 / 28 / 44 |
| Cash you put in before it pays for itself | ~$31k | **~$23k** | ~$21k |
| Profitable for good from | Month 13 | **Month 10** | Month 7 |
| Profit stays above $10k/month from | Month 28 | **Month 16** | Month 13 |
| Recurring revenue (ARR) at month 36 | $273k | **$404k** | $821k |

**How to read it:**
- "Profit to you" is the business's operating profit minus equipment purchases, with no salary for you. You do the installs and support, so there's no labor cost.
- If you paid someone $90/hour to do that work, Base Year-3 profit would be ~$259k instead of ~$317k.
- By Year 3, the Upside case is 44 hours a week. That's not a side business anymore; it's the signal to go full-time.

**The big unknown is sales, not margins.** Landing 6 clients in Year 2 while holding a day job depends on warm introductions and an IT partner, since cold email to these firms gets ~0.6% replies ([05](05-go-to-market.md#9-funnel-math)). The Conservative column shows what happens if clients come slower: still profitable by Year 2, just smaller.

---

## 2. What changes from the full-time plan

| | Full-time plan ([03](03-pricing-and-unit-economics.md)) | Side business |
|---|---|---|
| Founder pay | 2 founders, $72k → $264k/year | $0 salary: you keep the profit |
| Hires | 4, triggered by client count | None |
| Tiers sold | Practice, Firm, Enterprise | Practice and Firm only (Enterprise support doesn't fit around a day job) |
| Operating costs | $166k → $966k/year | ~$32k → ~$53k/year (insurance, legal, pen test, tools, local marketing) |
| Demo/pilot hardware | $36k | One $5.5k demo box, which doubles as a pilot box for small clients |
| Security audits | SOC 2 in Years 2–3 | Pen test only; small firms rarely require SOC 2 |
| Prices and unit economics | Same | Same |

---

## 3. Your time budget (Base case)

| Hours per year | Year 1 | Year 2 | Year 3 |
|---|---|---|---|
| Building and maintaining the product | 400 | 200 | 200 |
| Prospecting and networking | 75 | 100 | 100 |
| Selling (≈40 hours per new client, including demos you lose) | 80 | 240 | 280 |
| Installs (20 hours Practice, 40 Firm) | 60 | 160 | 200 |
| Support (2.5 hours/month Practice, 5 Firm) | 22 | 195 | 443 |
| Admin (bookkeeping, contracts, insurance) | 100 | 100 | 100 |
| **Total** | **~740 (14/week)** | **~995 (19/week)** | **~1,320 (25/week)** |
| **Effective pay per hour** | (investing) | **~$140** | **~$240** |

The hour estimates for building, selling, and admin are planning assumptions; install and support hours come from the model. **Year 1 is front-loaded.** The product needs ~400 hours before the first pilot, which is about **5–6 months at 15–20 hours a week**. That's why the first client lands around month 7–9.

**The catch: a lot of this work happens during business hours.** Demos, installs, and support calls all happen when law firms and CPA firms are open. Plan for it:
- **Batch demos** into one weekday morning a week or two a month, using PTO or flex time.
- **Install after hours or on weekends.** Clients usually prefer that, because it means no disruption.
- **Promise next-business-day support**, not 4-hour response, and use a shared inbox.

---

## 4. Money timeline (Base case)

| When | What happens |
|---|---|
| Months 1–9 | You invest ~$23k total: demo box $5.5k, insurance ~$4k, legal and contracts ~$8k, pen test ~$5k, tools and marketing. Revenue starts with the first design partner around month 7–9. |
| **Month 10** | Profitable for good |
| **Month 16** | Profit stays above **$10k/month** (~$120k/year pace) |
| Month 24 | ~$18k/month in subscriptions; ~$129k cumulative profit since the start |
| Month 36 | ~$34k/month in subscriptions; ~$35k/month profit; **~$446k cumulative profit** (pre-tax) |

---

## 5. Five rules that make it work on the side

1. **Check your employment agreement before you write more code.** Look for IP-assignment, moonlighting, and conflict-of-interest clauses. Some states limit an employer's claim on inventions you make on your own time with your own equipment, but usually not if the work relates to your employer's business. Never use employer time, laptops, or accounts. If in doubt, a one-hour consult with an employment lawyer is cheap insurance.
2. **Stay narrow.** One workflow (the medical chronology), one metro, Practice and Firm tiers only, and a cap of 10–15 clients until you decide to go full-time.
3. **Let an IT partner (MSP) be your field team.** They do installs and first-line support; you supply the software and AI layer. You give up ~25% of the subscription on those clients but save most of the daytime hours. Set `Assumptions!B31` in the workbook to see the effect.
4. **Consider selling a simpler package first.** A private, offline chat-with-your-documents box built on open-source tools (e.g., AnythingLLM or LibreChat, both MIT-licensed) can be installed in weeks. Design partners start paying sooner, and the chronology workflow gets added as it's built. It's less differentiated, so treat it as a bridge, not the product.
5. **Protect yourself.** Form an LLC, carry tech E&O and cyber insurance before the first pilot ([07](07-risks-and-compliance.md#6-insurance)), and set aside ~30% of profit for taxes. Side-business profit is self-employment income: income tax plus self-employment tax, paid quarterly. (Not tax advice; talk to a CPA.)

---

## 6. When to go full-time

Go full-time when any of these is true:
- **Profit has matched your salary for ~6 months.** In the Base case that's somewhere around month 16–24, depending on your salary.
- **You're consistently past ~25 hours a week**, or turning down demos because of your day job.
- **Mid-size firms want to buy and need faster support** than a side business can promise.

At that point, switch to the full-time plan and its hiring triggers ([03](03-pricing-and-unit-economics.md#6-three-year-projection)). You'll be doing it with paying customers, references, and cash in the bank instead of savings.

---

## 7. Using the side-business model

[`financial-model-side-business.xlsx`](financial-model-side-business.xlsx) has the same sheets as the full-time model, with these inputs:

| Input | Side-business setting | Where to change it |
|---|---|---|
| Your labor cost | $0/hour (you do the work) | `Assumptions!B23` (set ~$90 to see profit if you paid someone) |
| Founder pay and hires | $0; hires never trigger | `Opex Plan` |
| Scenario | Base (2 / 6 / 7 new clients by year) | `Assumptions!B4` (1 = Conservative, 3 = Upside) |
| Year-1 discount | 50% (your first clients are design partners) | `Assumptions!B26` |
| Partner resale | 0% | `Assumptions!B31` |

The hours in §3 are calculated outside the workbook from its client counts, using the per-client hours on the `Assumptions` sheet plus the build, sales, and admin estimates above.
