# AirGappedAI — Privacy-First AI Document Processing

A **local-only, air-gapped** document processing API built in C# (.NET 8). It uses a locally-hosted LLM ([Ollama](https://ollama.com)) to extract structured data from sensitive documents — **no data ever leaves your network**.

---

## Why This Exists

Most AI document pipelines send your data to third-party cloud APIs. That is a non-starter for industries handling sensitive records — medical, legal, and financial. This system is designed from the ground up so that:

- The LLM runs **entirely on-premise** via Ollama
- No document content is transmitted outside `localhost`
- The architecture is **industry-agnostic** — the same pipeline handles any document category via a configurable prompt factory

---

## Architecture Overview

```
POST /api/process
      │
      ▼
DocumentProcessingService
      │
      ├─► IPromptFactory.GetSystemPrompt(category)
      │         └─ Returns a strict, JSON-only system prompt
      │            for "Medical", "Legal", or "Financial"
      │
      └─► ILocalAiProvider.AnalyzeTextAsync(text, systemPrompt)
                └─ OllamaProvider → llama3 @ localhost:11434
                         └─ Deserializes response → ProcessedDocument
```

### Key Components

| File | Responsibility |
|---|---|
| `Services/ClaimProcessingService.cs` | `ProcessedDocument` model, `ILocalAiProvider` interface, `DocumentProcessingService` orchestrator |
| `Services/PromptFactory.cs` | `IPromptFactory` — returns category-specific system prompts that force raw JSON output |
| `Services/OllamaProvider.cs` | Concrete `ILocalAiProvider` — calls Ollama, deserializes response, handles malformed JSON gracefully |
| `Program.cs` | Minimal API setup, DI registration, `POST /api/process` endpoint |
| `tests/DocumentProcessor.Specs/` | xUnit specs using Moq + FluentAssertions |

---

## Data Model

Every AI response is deserialized into a `ProcessedDocument`:

```json
{
  "RequiresManualReview": true,
  "DocumentCategory": "Legal",
  "ExtractedData": {
    "document_type": "contract",
    "parties": "Acme Corp, John Doe",
    "effective_date": "2026-01-15",
    "jurisdiction": "England and Wales",
    "key_obligations": "payment within 30 days, confidentiality",
    "governing_law": "Laws of England and Wales"
  }
}
```

`RequiresManualReview` is set to `true` automatically by the LLM when it detects high-risk content (e.g. emergency medical conditions, penalty clauses, large financial amounts), or by the system if the AI returns malformed JSON.

---

## Supported Document Categories

| Category | Key fields extracted |
|---|---|
| `Medical` | primary diagnosis, medications, procedures, ICD-10 codes, patient risk level |
| `Legal` | document type, parties, effective date, jurisdiction, obligations, governing law |
| `Financial` | document type, currency, total amount, transaction date, counterparty, account references |

Adding a new category requires one new `case` in `PromptFactory.cs`.

---

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Ollama](https://ollama.com/download) running locally
- The `llama3` model pulled:

```bash
ollama pull llama3
```

---

## Running the API

```bash
cd src/DocumentProcessor.Api
dotnet run
```

The API will be available at `http://localhost:5000` (or check `Properties/launchSettings.json`).

Swagger UI is available in Development at: `http://localhost:5000/swagger`

---

## API Reference

### `POST /api/process`

**Request body:**

```json
{
  "text": "Patient presents with acute myocardial infarction. History of hypertension.",
  "category": "Medical"
}
```

**Response (`200 OK`):**

```json
{
  "requiresManualReview": true,
  "documentCategory": "Medical",
  "extractedData": {
    "primary_diagnosis": "acute myocardial infarction",
    "secondary_conditions": "hypertension",
    "medications": "",
    "procedures": "",
    "patient_risk_level": "high",
    "icd_codes": "I21.9"
  }
}
```

**PowerShell example:**

```powershell
Invoke-RestMethod -Uri "http://localhost:5000/api/process" `
  -Method Post `
  -ContentType "application/json" `
  -Body '{"text": "Indemnity clause binding both parties.", "category": "Legal"}'
```

---

## Running the Tests

```bash
dotnet test
```

Tests use Moq to mock both `ILocalAiProvider` and `IPromptFactory`, so they run **instantly** with no Ollama dependency.

---

## Error Handling

If the LLM returns malformed or non-JSON output, the system returns a safe fallback rather than throwing:

```json
{
  "requiresManualReview": true,
  "documentCategory": null,
  "extractedData": {
    "error": "AI returned malformed JSON: ...",
    "raw_response": "..."
  }
}
```

---

## Extending the System

| Goal | What to change |
|---|---|
| Add a new document category | Add a `case` in `PromptFactory.cs` |
| Swap the LLM model | Change `ModelName` constant in `OllamaProvider.cs` |
| Support multiple models | Inject model name via `appsettings.json` and `IConfiguration` |
| Add authentication | Add `app.UseAuthentication()` / `app.UseAuthorization()` in `Program.cs` |
