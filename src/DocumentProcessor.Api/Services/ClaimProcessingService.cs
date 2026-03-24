using System.Collections.Generic;
using System.Threading.Tasks;

namespace DocumentProcessor.Api.Models
{
    public class ProcessedDocument
    {
        public bool RequiresManualReview { get; set; }
        public string? DocumentCategory { get; set; }
        public Dictionary<string, string> ExtractedData { get; set; } = new();
    }
}

namespace DocumentProcessor.Api.Services
{
    public interface ILocalAiProvider
    {
        Task<Models.ProcessedDocument> AnalyzeTextAsync(string rawText, string systemPrompt);
    }

    public class DocumentProcessingService
    {
        private readonly ILocalAiProvider _aiProvider;
        private readonly IPromptFactory _promptFactory;

        public DocumentProcessingService(ILocalAiProvider aiProvider, IPromptFactory promptFactory)
        {
            _aiProvider = aiProvider;
            _promptFactory = promptFactory;
        }

        public async Task<Models.ProcessedDocument> ProcessDocumentAsync(string rawDocumentText, string documentCategory)
        {
            if (string.IsNullOrWhiteSpace(rawDocumentText))
                return null;

            var systemPrompt = _promptFactory.GetSystemPrompt(documentCategory);
            var result = await _aiProvider.AnalyzeTextAsync(rawDocumentText, systemPrompt);

            return result;
        }
    }
}