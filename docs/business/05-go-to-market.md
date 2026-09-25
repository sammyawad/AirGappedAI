# 05 — Go-to-Market: Landing Page, Demo, Client List, Outreach

> How a startup with no brand, no logos, and no case studies wins its first 10 clients in a trust-driven market.

---

## 1. Positioning

**One-liner**

> A private AI server that sits in your office and works with the internet unplugged. Your documents never leave the building.

**Positioning statement** (internal)

> For law firms, medical organizations, and financial firms that can't risk client data in the cloud, [Brand] is a turnkey private AI appliance. Unlike cloud AI tools, nothing leaves your network, you pay one flat monthly fee with unlimited users, and it keeps working even if we disappear tomorrow.

### Four message pillars (and the proof for each)

| Pillar | Proof you show, not tell |
|---|---|
| **Nothing leaves your building** | The Unplugged Demo (§4): pull the network cable, then run their documents. Let their IT person watch the firewall. |
| **Built for your obligations** | A one-page map from their rules (ABA Op. 512, HIPAA, IRC §7216, GLBA/Reg S-P) to product features (audit log, access control, no training on data, citations for supervision). |
| **Flat price, unlimited users** | Pricing page with published "starting at" tiers. No per-seat or per-token meter. |
| **No lock-in, no startup risk** | Open-weight models, standard hardware the client owns, source-code escrow on request. "If we vanish, the box keeps working." |

The last pillar turns the startup's biggest weakness, no track record, into a talking point. With a cloud vendor, the client's data and workflow die with the vendor. With an appliance they own, they don't.

### Words to avoid

- ❌ "HIPAA certified", "ABA approved", "SOC 2 compliant" (until you have the report), "100% accurate", "replaces paralegals"
- ✅ "Designed to help you meet…", "supports your HIPAA program", "human review built in", "every answer cites its source page"

The FTC has pursued deceptive AI claims ("Operation AI Comply", 2024), and lawyers will read your claims closely. Under-claim.

---

## 2. Beachhead and ideal customer profile

Focus beats breadth. Pick **one vertical and one metro** for the first 90 days. See [01](01-market-and-regulation.md) for the full segment ranking.

**Primary: litigation law firms, 10–150 attorneys, handling medical records.** Insurance defense, medical malpractice, workers' comp, and personal injury.

- Heaviest document loads in law. A single case can mean thousands of pages of medical records.
- The records are PHI and privileged work. ABA Opinion 512 requires informed client consent before using self-learning AI tools, and *U.S. v. Heppner* (Feb 2026) found consumer-AI chats weren't privileged. On-prem sidesteps both: Florida's bar says AI that doesn't disclose to a third party needs no client consent ([01](01-market-and-regulation.md#3-legal)).
- Client restrictions on AI exist but are still rare (about 2% of outside-counsel guidelines mention AI). Ask about them in discovery calls; when present, they accelerate the deal.
- The **medical chronology** workflow reuses both of the repo's existing extractors (Medical + Legal).
- Decisions are made by a managing partner, not a procurement committee.

**Secondary (time-boxed now): CPA and tax firms, 5–75 staff.** Tax season runs January to April, so pilots have to be installed by December. IRC §7216 and the FTC Safeguards Rule give a crisp compliance hook, and K-1/W-2/1099 extraction is painful busy-season work.

**Later:** behavioral health and hospital legal/compliance teams, community banks and credit unions (need SOC 2 first), and defense contractors under CMMC (strongest pull, but heavier compliance obligations for you).

### Buyer map (law firm example)

| Role | Title | What they need to hear |
|---|---|---|
| Economic buyer | Managing partner, COO | Hours saved per case, flat cost, malpractice/ethics risk reduced |
| Champion | Senior paralegal, litigation support manager, practice-group partner | "The chronology that took 3 days takes 1 hour, and I check it with page links" |
| Technical evaluator | IT director or the firm's MSP | No inbound or outbound internet, AD login, patching plan, who has access |
| Blocker | General counsel/ethics partner, cautious senior partners | ABA 512 mapping, no training on data, audit trail, human review |

---

## 3. Landing page

### Site map (one page to start, plus three support pages)

1. **Home** (the landing page below)
2. **Security**: architecture diagram, data flow, "what leaves the box: nothing", update process, and a downloadable security whitepaper
3. **Pricing**: three tiers with "starting at" prices (see [03](03-pricing-and-unit-economics.md))
4. **Book a demo**: calendar embed (Cal.com or Calendly) plus a short qualification form

### Wireframe and copy

**Hero**
> # AI for your most confidential work, without the cloud.
> A private AI server for law firms, medical practices, and financial firms. It sits in your office, reads your documents, and works with the internet unplugged.
>
> **[Book an unplugged demo]** · [See pricing]
>
> *Nothing leaves your building · Flat monthly price, unlimited users · You own the hardware*

**Problem**
> ### Your team is already using AI. The question is where your client data is going.
> Staff paste confidential documents into consumer chatbots every day. Meanwhile your ethics rules, HIPAA, and your clients' outside-counsel guidelines say you're responsible for where that data goes. Most firms respond by banning AI, and then falling behind firms that don't.

**How it works** (three steps with icons)
> 1. **We deliver a pre-configured AI server** sized for your team.
> 2. **It plugs into your network, not the internet.** Your staff sign in with their normal work login.
> 3. **Your team drops in documents** and gets summaries, extracted data, and answers, each citing the source page.

**Use cases** (tabs by vertical)

| Legal | Medical | Financial |
|---|---|---|
| Medical chronologies from records, with page cites | Record summarization for referrals and reviews | W-2 / 1099 / K-1 data extraction |
| Contract review against your playbook | Prior-authorization letter drafts | Bank-statement and invoice analysis |
| Deposition and transcript summaries | Coding suggestions with clinician review | Client letters and notice responses |
| Discovery first-pass triage | Policy and procedure Q&A | Policy Q&A for staff |

**Proof block** (until you have customer logos)
> - **Watch it work with the cable unplugged**: embed the 2-minute demo video
> - **Accuracy you can check**: "Every extracted field links to the page it came from. Every output can be reviewed before it's used."
> - **Built by**: founder photos and short bios. In a trust market, real faces beat stock art.
> - Advisors: a named attorney, compliance officer, or CPA, once you have them

**Comparison** (honest, not a hit piece)

| | Cloud AI tools | [Brand] |
|---|---|---|
| Where documents are processed | Vendor's cloud | A server in your office |
| Works without internet | No | Yes |
| Pricing | Per seat, often per usage | Flat monthly, unlimited users |
| Vendor can access your data | Governed by contract | Physically not possible unless you open access |
| Latest frontier models | ✅ Yes | Strong open-weight models, updated quarterly |
| Built-in legal research databases | Some (e.g., CoCounsel, Lexis) | No: works on *your* documents |

Being candid about what you're *not* (no case-law database, not the frontier model) builds more credibility than pretending to beat Harvey.

**Pricing teaser**, **FAQ**, and **final CTA**

FAQ questions to answer on the page:
- Is a local AI model as good as ChatGPT? *(Answer: for document work on your files, modern open models are very capable; we show measured accuracy on your document types during the pilot.)*
- What happens if your company goes out of business?
- Do we need a BAA? *(We sign one. Because the box is in your office, we don't have access to PHI unless you grant support access.)*
- Does this satisfy ABA Formal Opinion 512? *(It addresses the confidentiality risks; you still need a firm AI policy, training, and supervision. We provide templates.)*
- How are updates delivered if it's offline?
- Who can see what? *(Your AD groups, matter-level workspaces, full audit log.)*

**Lead magnet** for visitors who aren't ready to book: *"The Private AI Checklist for Law Firms: 12 questions to ask any AI vendor about confidentiality (mapped to ABA Op. 512)."* Gate it with an email field; it feeds the nurture sequence.

### Build notes

- Static site (Astro, Next.js static export, or plain HTML), hosted on Netlify or Cloudflare Pages: **$0–20/month**. Domain: ~$15/year.
- Analytics: privacy-friendly (Plausible or Fathom, ~$9–15/month). A privacy company shouldn't ship Google trackers on its own site.
- **Clear the name before you build** (see [07](07-risks-and-compliance.md)).
- Budget one to two weeks of founder time, or $2k–6k for a freelancer with a template.

---

## 4. The demo

Three levels, used at different stages.

### Level 1: 2-minute video (top of funnel)

Screen recording plus a phone shot of the network cable being pulled out:
1. Show the box and unplug the network cable (on camera).
2. Show `ping google.com` failing.
3. Drop in an 80-page synthetic medical record → a chronology appears with page links.
4. Click a citation → the source page opens.
5. Ask a question in chat ("When was the first mention of lumbar pain?") → answer with a cite.
6. Export to Word/Excel.

Use it in cold emails (as a thumbnail link), on the landing page, and on LinkedIn.

### Level 2: The Unplugged Demo (the closer)

The single most important sales asset. Bring a portable box, such as a small desktop AI system or a high-memory laptop (see [04](04-infrastructure-and-logistics.md)), to the prospect's office.

1. Set it on their conference table. Let their IT person confirm it's not on the network.
2. Run **their own** sample documents (redacted if they prefer), not yours.
3. Show extraction, citations, chat, and the audit log recording what just happened.
4. Leave behind a one-page summary of what it did and the pilot offer.

A cloud vendor can't do this demo, which is why it disarms the "who are you?" question. The demo *is* the proof.

### Level 3: Paid pilot (the proof of value)

- 30–45 days on a loaner or pilot box in their office, on real work
- Success criteria agreed in writing up front: for example, "chronology for 5 closed cases in under 2 hours each with ≥95% of events captured versus the paralegal's version"
- Pilot fee credited toward purchase (see [03](03-pricing-and-unit-economics.md))

### Demo data rules

- **Never** use real client, patient, or customer data in demos you bring to other prospects.
- Use synthetic or public data: Synthea patients, CUAD contracts, synthetic tax forms (see [06](06-product-roadmap.md)).
- Each prospect's own documents stay on the demo box only for that session and get wiped in front of them. Put that in writing.

---

## 5. "Client list": design partners first, then logos

You don't have a client list yet, so **don't fake one**. No "trusted by" logo bars without written permission. Build it deliberately:

### Design partner program (first 3–5 clients)

| You give | You get |
|---|---|
| ~50% off year-one subscription; setup at cost | A written case study with real numbers (hours saved) |
| Direct founder access; features built for their workflow | Permission to name them (or "a 40-attorney insurance defense firm in Dallas") |
| Month-to-month terms for the first 6 months | Two reference calls per quarter |
| Price lock for 3 years | Monthly feedback session |

**Selection criteria:** one workflow with measurable volume (e.g., 20+ medical chronologies a month), a champion who'll use it daily, within driving distance, and a decision maker who can sign in 30 days.

**Where to find them first:** your own network, the founders' former employers, their lawyers, accountants, and doctors, and local MSPs' existing clients (see §7). Warm intros close 5–10× faster than cold outreach.

### Prospect list (the target list)

Build a list of 300–500 target organizations in your beachhead segment and metro, then work it systematically. Public sources:

| Segment | Where the list comes from | Cost | Filters |
|---|---|---|---|
| Law firms | State bar directories and Martindale (one lookup at a time), firm websites, defense-counsel association member lists | Free, manual; bulk export generally not offered | 10–150 attorneys; practice area: insurance defense, med-mal, workers' comp, PI |
| Medical orgs | [CMS NPPES](https://download.cms.gov/nppes/NPI_Files.html): every provider ID number with specialty and address, monthly full file (~1.1 GB zipped); [HRSA](https://data.hrsa.gov/data/download) health-center sites | Free | Organization NPIs by specialty code (behavioral health, multi-specialty groups) |
| CPA firms | State board of accountancy registries, state CPA society directories | Free, manual | 5–75 staff; tax-heavy practices |
| Community banks | [FDIC BankFind API](https://api.fdic.gov/banks/docs) | Free, no key | $250M–$5B assets |
| Credit unions | [NCUA call-report data](https://ncua.gov/analysis/credit-union-corporate-call-report-data/quarterly-data) | Free | $250M–$5B assets |
| RIAs | [SEC Form ADV data](https://www.sec.gov/data-research/sec-markets-data/information-about-registered-investment-advisers-exempt-reporting-advisers) (monthly) | Free | $100M–$2B AUM, 5–50 employees |
| Defense contractors | [SAM.gov Entity API](https://open.gsa.gov/api/entity-api/) | Free with a key | Small businesses with DoD contracts in NAICS codes likely to handle CUI |

For contact details, Apollo ($49–119/user/month), Hunter ($34/month), and LinkedIn Sales Navigator ($1,080–1,800/year) are enough. ZoomInfo (median ~$33,500/year) is overkill. Prices from [Vendr](https://www.vendr.com/marketplace/apollo-io), [Hunter](https://hunter.io/pricing), and [LinkedIn](https://business.linkedin.com/sales-solutions/compare-plans).

Use the CRM template in [`prospect-list-template.csv`](prospect-list-template.csv) (columns match a HubSpot or Pipedrive import). HubSpot's free CRM is enough for the first year.

---

## 6. Outreach

### Cadence (per prospect, about 3 weeks, 7 touches)

| Day | Channel | Touch |
|---|---|---|
| 1 | LinkedIn | View profile; connect with a short note (no pitch) |
| 2 | Email | Email 1: the problem and their specific obligation |
| 5 | Phone | Call; if voicemail, 20 seconds, reference the email |
| 8 | Email | Email 2: the 2-minute video |
| 12 | LinkedIn | Message: offer the checklist or an invite to a webinar |
| 16 | Email | Email 3: the Unplugged Demo offer, with specific dates you'll be in their area |
| 21 | Email | Email 4: breakup ("should I close the file?") |

### Deliverability and compliance (set up before the first send)

- **Send from a separate domain** (e.g., `get{brand}.com`), never your main domain. Warm it up for 2–3 weeks.
- **SPF, DKIM, and DMARC** records, plus a one-click unsubscribe. Google and Yahoo require these of bulk senders (Google since Feb 2024), and Microsoft rejects failing mail from high-volume senders since May 2025 ([Google](https://support.google.com/a/answer/81126?hl=en), [Microsoft](https://techcommunity.microsoft.com/blog/microsoftdefenderforoffice365blog/strengthening-email-ecosystem-outlook%E2%80%99s-new-requirements-for-high%E2%80%90volume-senders/4399730)).
- **CAN-SPAM applies to B2B email:** physical postal address, a working opt-out honored within 10 business days, and honest subject lines. Penalties run up to **$53,088 per email** ([FTC](https://www.ftc.gov/business-guidance/resources/can-spam-act-compliance-guide-business)).
- **Keep volume small and personal:** 20–40 new prospects per day per sender. Lists under 50 contacts get roughly 3× the reply rate of lists over 1,000 ([Woodpecker 2026](https://woodpecker.co/blog/cold-email-statistics/)).
- **LinkedIn:** about 100 connection invitations per week ([Evaboot](https://evaboot.com/blog/linkedin-limits)).
- **Phone:** calling business lines is fine. Don't text prospects' mobile numbers without consent.

### Templates

Fill every `{field}`. Personalize the first line; generic first lines get deleted. Every commercial email must include your **physical postal address** and an **opt-out line**.

**Law firm, Email 1**

> **Subject:** AI, privilege, and your medical records
>
> {First name},
>
> {Personalized line: e.g., "Saw {Firm} just added two attorneys to the Houston insurance defense team."}
>
> Most litigation firms I talk to have the same problem: paralegals spend days turning medical records into chronologies, and AI could do the first pass in an hour. But ABA Opinion 512 says self-learning AI tools need informed client consent (boilerplate doesn't count), and in February a federal judge ruled that chats with a consumer AI tool weren't privileged.
>
> We built a small AI server that sits in your office and works with the internet unplugged. Nothing goes to a third party, and every line of the chronology links back to its source page.
>
> Worth 20 minutes to see it run on a sample record?
>
> {Name}
> {Company} · {Postal address} · Reply "no thanks" and I won't follow up.

*Florida variant, replacing the second paragraph's last sentence:* "The Florida Bar's Opinion 24-1 says AI that doesn't disclose confidential information to a third party doesn't require client consent. That's exactly how this works." *California (if SB 574 is signed):* "California's new SB 574 limits confidential data in AI to systems where access is restricted to you and people you authorize."

**Law firm, Email 2**

> **Subject:** 2 minutes, cable unplugged
>
> {First name}, here's a 2-minute video of the system building a chronology from an 80-page record, with the network cable pulled out on camera: {link}
>
> If your team handles more than ~10 chronologies a month, happy to show it on your own documents at your office.

**Law firm, Email 3 (Unplugged Demo offer)**

> **Subject:** In {City} on {dates}
>
> {First name}, I'll be meeting firms in {City} on {date 1} and {date 2}. I can bring the box to your conference room, have your IT person confirm it's offline, and run it on a redacted record of your choosing. 30 minutes, and your documents are wiped before I leave.
>
> Would either date work?

**Breakup (all segments)**

> **Subject:** Close the file?
>
> {First name}, I haven't heard back, so I'll assume private AI isn't a priority right now. If that changes, the 2-minute video is here: {link}. I'll stop reaching out.

**CPA firm, Email 1**

> **Subject:** AI before tax season, without the §7216 headache
>
> {First name},
>
> Busy season is {N} weeks out. The firms we talk to want AI to pull data from K-1s, 1099s, and brokerage statements, but uploading client return information to a cloud AI raises IRC §7216 consent and FTC Safeguards Rule questions most firms would rather not answer.
>
> We install a private AI server in your office that extracts that data with no internet connection. Every value links to the page it came from, so your reviewers can check it fast.
>
> We're taking 3 firms as pilot partners for the 2027 season at a founding discount. Want to see it on a sample K-1?

**Medical organization, Email 1**

> **Subject:** AI on patient records, without sending them out
>
> {First name},
>
> {Personalized line.} Your clinicians and staff want AI for summaries, referral letters, and prior-auth paperwork, but every new cloud AI vendor means another BAA, another security review, and PHI leaving your control.
>
> We install a private AI server inside your network. It works with the internet unplugged, keeps a full audit log, and nothing leaves the building. Worth a 20-minute look?

**MSP partner, Email 1**

> **Subject:** Private AI for your law-firm clients
>
> {First name}, your clients are asking about AI, and most of them shouldn't be pasting client files into ChatGPT. We build turnkey private AI servers for law and medical offices: no internet required, AD login, audit log.
>
> We handle the AI; you keep the client relationship, the hardware margin, and {X}% of the recurring subscription. Open to a 20-minute call?

**LinkedIn connection note** (under 200 characters)

> Hi {First name}. I work with litigation firms on AI that runs fully offline, inside the firm. Not pitching here, just following the {practice area} space. Glad to connect.

### Phone script (30 seconds)

> "Hi {name}, this is {you} with {Company}. I'll be brief: we install AI servers inside law firms that run with no internet connection, so records never leave the building. Firms use it mostly for medical chronologies. I sent a 2-minute video last week. Is AI on client documents something your firm is working through, or is it off the table right now?"

Then **listen.** Either answer is useful: "off the table" usually means "because of confidentiality", which is exactly your opening.

---

## 7. Channels that borrow trust

### Managed service providers (MSPs): the most important channel

Small law firms, practices, and CPA firms outsource IT to MSPs. A 30-user firm typically pays its MSP **$3,000–12,000/month** ($100–400 per user; [Datapath 2026](https://www.mydatapath.com/blog/managed-it-services-cost-pricing-guide-2026/)). That MSP is the trusted technical advisor your startup isn't yet. One partner can bring 20–100 potential clients.

**Partner terms to offer** (typical channel ranges; [Chanimal](https://chanimal.com/resources/pricing/reseller-margins/), [Compare the Cloud](https://www.comparethecloud.net/articles/uk-msps-stop-chasing-hardware-margin-start-selling-monthly-outcomes-subscription)):

| Partner type | What they do | What they earn |
|---|---|---|
| **Referral partner** | Introduces the client; you sell and deliver | 10–15% of first-year contract value |
| **Reseller partner** | Sells, owns the relationship, handles tier-1 support; you deliver AI setup, workflows, and updates | 20–30% off the subscription, plus the hardware margin |
| Both | Deal registration, so partners never compete with each other or with you | — |

- **Find them:** search "{city} law firm IT support", "{city} medical IT", "{city} CPA IT". Many specialize by vertical.
- **Start with 2–3 MSPs in your metro.** Offer each a free demo box for their own office.
- MSPs are already building do-it-yourself private-AI boxes ([02](02-competition.md#msps-already-selling-private-ai)). Position yourself as the AI layer they don't want to maintain.
- **Year 2:** distributors. Pax8 (47,000+ MSPs) onboards vendors by application and waitlist, and TD SYNNEX expects "a channel program" first ([Pax8](https://www.pax8.com/en-us/marketplace/vendors/), [Channelholic](https://www.channelholic.news/p/msps-need-to-accelerate-ai-evolution)).

### Professional associations and education

- **CLE webinars for lawyers.** Lawyers need ethics credit every year. A 60-minute, genuinely educational session on "Using generative AI without violating Rule 1.6", with no product pitch in the credited hour, fills seats. **The attendance roster (names and bar numbers) is a qualified lead list.** Accreditation is cheap:

  | State | Process | Fee |
  |---|---|---|
  | California | Single-activity approval | $159 per activity ([CalBar](https://www.calbar.ca.gov/legal-professionals/rules/rules-state-bar/appendix-schedule-charges-and-deadlines)) |
  | Illinois | Per-course application | $50 per course + $0.75 per Illinois attorney-hour ([IL MCLE](https://www.mcleboard.org/files/FAQs/ProviderFAQs/Fee_Schedule/What_are_the_Fees_for_Per_Course_Providers_Submitting_Individual_Applications_to_Accredit_Individual.aspx)) |
  | Texas | Per-course application | ~$20 per credit hour or $10 per Texas attendee, whichever is less (verify) |
  | New York | Per course, 60+ days ahead; experienced NY attorneys can count CA- or TX-approved courses | Verify ([NY Courts](https://www.nycourts.gov/continuing-legal-education-cle/faqs-cle-providers)) |
  | Multi-state | Services like Lawline CLE Concierge file for you | Quote |

- **Speaking slots:** state and local bar sections, defense-counsel associations, and CPA societies often want speakers. That's free marketing with built-in credibility.
- **Accelerators and startup zones:** ILTA's vetted **Startup Hub** at ILTACON is taking 2027 applications ([ILTA](https://www.iltacon.org/sponsors/startuphub)), and **CPA.com's 2027 Startup Accelerator** is open ([CPA.com](https://accelerator.cpa.com/)). Both give a no-name startup instant credibility with the right buyers.
- **Member-benefit programs** (bar, medical, and CPA societies): usually a royalty or revenue share plus a member discount, sometimes category-exclusive. Pursue after 3+ references.

### Conferences (next 12 months)

**Attend first, exhibit later.** Book meetings with your target list in advance, and walk the floor to meet partners. Buy a booth only once you have references and a proven demo.

| Event | When and where | Audience | Exhibit cost |
|---|---|---|---|
| **CS5** (CMMC) | Oct 22–23, 2026, National Harbor | Defense contractors (the test segment) | Not published |
| **ClioCon** | Oct 26–27, 2026, Boston | Small and mid-size law firms | By inquiry |
| **Legalweek** | Mar 1–3, 2027, NYC | Large-firm legal tech | Vendor pass (no booth) $4,995 |
| **ABA TECHSHOW** | Mar 3–6, 2027, Chicago | **Small and mid-size law firms: best fit** | 10×10 booth $5,050 + furniture $1,855 |
| ICBA LIVE | Mar 1–4, 2027, Las Vegas | Community banks | Registration opens this fall |
| T3 / Future Proof | Mar 2027, Las Vegas / Miami | RIAs | By inquiry |
| HIMSS27 | Apr 5–8, 2027, Chicago | Health systems | ~$15–22k all-in (estimate) |
| AICPA ENGAGE | ~Jun 7–10, 2027, Las Vegas | CPA firms | 10×10 inline booth $6,800 (2026 price) |
| **ILTACON** | Aug 8–12, 2027, Nashville | Law-firm IT leaders | Startup Hub (apply) |
| State MGMA chapter meetings | Various | Practice administrators | ~$1,500–2,000 per booth |

Sources: [ALM](https://www.event.law.com/legalweek/2027-pricing), [TECHSHOW](http://www.techshowsponsorships.com/2027-exhibitor-booths), [ICBA](https://www.icba.org/registration-icba-live), [HIMSS](https://www.himssconference.com/), [AICPA ENGAGE prospectus](https://www.cpa.com/sites/cpa/files/2026-01/ENGAGE_2026_Prospectus.pdf), [ILTA](https://www.iltacon.org/home), [Cyber AB](https://cyberab.org/News-Events/CS5-Conference), [ClioCon](https://cliocon.com/faq/), [NY MGMA](https://www.newyorkmgma.com/event-6453957).

### Content

- One practical piece per month for your beachhead: "How to build a medical chronology with AI without violating HIPAA", "ABA Op. 512 checklist", "What §7216 means for AI in your tax practice"
- Post the demo video and short clips on LinkedIn; founders' personal profiles outperform company pages.

---

## 8. Sales process

| Stage | Exit criteria | Typical length |
|---|---|---|
| 1. First meeting | Pain confirmed, volume known, buyer identified | — |
| 2. Unplugged Demo | Ran on their documents; champion engaged | 1–3 weeks |
| 3. Pilot proposal | Success criteria in writing; pilot fee agreed | 1–2 weeks |
| 4. Paid pilot | Criteria met; IT and security review passed | 30–45 days |
| 5. Contract | MSA, order form, BAA if healthcare, hardware ordered | 1–4 weeks |
| 6. Install and onboard | Acceptance test signed; users trained | 1–2 weeks |

**Security review kit** (prepare once, reuse forever): security whitepaper, architecture diagram, data-flow diagram, completed standard questionnaire (SIG Lite or CAIQ), pen-test summary (when available), insurance certificate, sample BAA and MSA, and an incident response summary.

### Objection handling

| Objection | Response |
|---|---|
| "We already have Microsoft Copilot" | "Great for email and Word. Copilot runs in Microsoft's cloud, so claim files and medical records sent there raise the consent and privilege questions. Many firms use both: Copilot for general work, this for the confidential files." |
| "Cloud vendors sign BAAs now" | "True, and for many uses that's fine. This is for the documents you or your clients don't want in anyone's cloud, and for firms that want a flat cost instead of per-seat pricing." |
| "Is a local model as good as GPT?" | "On general knowledge, frontier models still lead. On extracting and summarizing *your* documents, modern open models are very strong, and the pilot measures accuracy on your documents before you commit." |
| "You're a startup. What if you go under?" | "You own the hardware and it runs offline, so it keeps working. Models are open-weight. We offer source-code escrow. Compare that with a cloud vendor going under." |
| "Too expensive" | Reframe around their current cost: "A legal nurse consultant charges ~$2,500–5,000 per case. Even in-house, a paralegal chronology at 12 hours × $45 loaded is $540, and at 20 a month that's $10,800/month in labor." (Illustrative; use their numbers.) Mention that the box is typically deductible in year one. Then offer the smaller tier or a pilot. |
| "Our IT/MSP won't allow new hardware" | "We'll work with your MSP directly. Many MSPs partner with us and earn from it." |
| "We need to think about AI policy first" | "Makes sense. We'll send the AI policy template and the ABA 512 checklist. Would it help to have the demo as part of that discussion?" |

---

## 9. Funnel math

### Benchmarks, and why they force a channel strategy

| Benchmark | Figure | Source |
|---|---|---|
| Cold email replies, **legal, healthcare, and financial services** | **0.56–0.60%** of emails sent; roughly **1 meeting per ~6,000 emails** across the dataset | [Belkins 2025](https://belkins.io/blog/cold-email-response-rates) (7.5M emails) |
| Cold email replies, all industries (another method) | 3.43% average; top quarter 5.5%+ | [Instantly 2026](https://instantly.ai/cold-email-benchmark-report-2026) |
| Small, personalized lists | 5.8% for lists under 50 contacts vs. 2.1% over 1,000 | [Woodpecker 2026](https://woodpecker.co/blog/cold-email-statistics/) |

Plan from the conservative number. **Mass cold email to lawyers and doctors doesn't work.** Small, researched lists plus phone and LinkedIn do somewhat better, and warm channels do far better.

### Per 1,000 prospects worked with the full 7-touch cadence

| Step | Conservative | Optimistic |
|---|---|---|
| Conversations (reply, call connect, LinkedIn) | 1% → 10 | 4% → 40 |
| First meeting | 60% → 6 | 60% → 24 |
| Unplugged Demo | 60% → 4 | 60% → 14 |
| Paid pilot | 35% → 1–2 | 40% → 6 |
| Closed-won | 60% → **~1 client** | 70% → **~4 clients** |

Those rates are planning assumptions, not benchmarks. Track your real ones from week 1.

**Implication:** the Base plan's 5 Year-1 clients ([03](03-pricing-and-unit-economics.md)) can't come from cold outreach alone. Target this pipeline mix by month 6:
- **~40%** from warm intros (your network, advisors, design-partner referrals)
- **~30%** from MSP partners
- **~20%** from CLE, speaking, and events
- **~10%** from cold outbound

Typical sales cycles (estimates): small law firms 2–8 weeks; mid-size firms 3–9 months (IT plus a security questionnaire); CPA firms 1–3 months, but **not between January and April 15**; community banks 6–12+ months.

### Make the hardware easy to buy

- **The whole box is deductible in year one.** The Section 179 limit is **$2.56M for 2026**, and **100% bonus depreciation is now permanent** for equipment acquired after Jan 19, 2025 ([IRS Rev. Proc. 2025-32](https://www.irs.gov/pub/irs-drop/rp-25-32.pdf), [IRS Notice 2026-11](https://www.irs.gov/pub/irs-drop/n-26-11.pdf)).
  - Example: a $25k box at a 30–40% combined tax rate saves the firm roughly $7.5–10k in taxes (estimate).
  - Section 179 can't exceed taxable income, and nonprofits get no benefit. Say "ask your CPA", not "it's free".
- **Leasing:** Dell Financial Services ($1 buyout or fair-market-value options; can cover hardware, software, and services), or third-party lessors like LEAF and GreatAmerica ([Dell](https://www.dell.com/en-us/dt/payment-solutions/index.htm)). Leasing turns a $25k purchase into a monthly line item.

### Year-1 go-to-market and operating budget (excluding salaries)

| | Lean | Moderate |
|---|---|---|
| Formation, contracts, bookkeeping | ~$6.5k | ~$21.6k |
| Insurance (tech E&O + cyber + general liability) | ~$3.9k | ~$13.1k (adds D&O) |
| Security (pen test, HIPAA program; SOC 2 deferred) | ~$9k | ~$49k (adds Vanta + SOC 2 Type I) |
| Prospecting tools | ~$3.6k | ~$14.2k |
| CLE accreditation | ~$1.2k | ~$7k |
| Events and travel | ~$13.9k | ~$51.2k |
| Member programs, website, partner enablement | ~$4k | ~$25k |
| Demo and pilot hardware | ~$12k | ~$40k |
| Contingency (10%) | ~$5.4k | ~$22.1k |
| **Total** | **~$59.5k** | **~$243k** |

Built from 2026 price sources: [Stripe Atlas](https://stripe.com/atlas), [Insureon](https://www.insureon.com/technology-business-insurance/cost), [Vouch](https://www.vouch.us/blog/startup-insurance-costs), [soc2auditors.org](https://soc2auditors.org/soc-2-audit-cost/), [Bright Defense](https://www.brightdefense.com/resources/penetration-testing-pricing/), [Medcurity](https://medcurity.com/hipaa-compliance-cost/), and the event links above. The financial model uses figures between the two columns ([03](03-pricing-and-unit-economics.md)).

---

## 10. First 90 days

| Weeks | Product | Go-to-market |
|---|---|---|
| 1–2 | Fix verified bugs; config-driven models; structured outputs | Pick the new name and get a clearance opinion ([07](07-risks-and-compliance.md#1-the-name)); form the LLC; draft MSA, BAA, and pilot agreement; apply to NVIDIA Inception (free) |
| 3–4 | PDF/OCR upload; web UI; synthetic demo data | Landing page live; record the 2-minute video; build the first 300-prospect list; set up the sending domain |
| 5–6 | Medical chronology workflow with citations | Warm-intro outreach to your network; approach 3 local MSPs; **CPA track:** 5 warm intros to CPA firms for pre-season pilots |
| 7–8 | Portable demo box; offline installer | 10+ Unplugged Demos booked; pitch a CLE webinar to a local bar association; apply to ILTA Startup Hub and CPA.com Accelerator |
| 9–10 | Auth, audit log, admin page | Sign 2–3 design partners; start paid pilots (CPA pilots installed by mid-December) |
| 11–13 | Accuracy harness; fix what pilots surface | Outreach at 20–40 new prospects a day per sender; capture time-savings data for the first case study |

**Target at day 90:** 2–3 design partners in paid pilots, 10+ qualified opportunities in pipeline, and time-savings data being captured for the first case study.
