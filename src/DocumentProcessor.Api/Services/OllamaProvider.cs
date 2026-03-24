using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DocumentProcessor.Api.Models;
using OllamaSharp;
using OllamaSharp.Models.Chat;

namespace DocumentProcessor.Api.Services
{
    public class OllamaProvider : ILocalAiProvider
    {
        private const string OllamaEndpoint = "http://localhost:11434";
        private const string ModelName = "llama3";

        private readonly OllamaApiClient _ollamaClient;

        public OllamaProvider()
        {
            _ollamaClient = new OllamaApiClient(OllamaEndpoint, ModelName);
        }

        public async Task<ProcessedDocument> AnalyzeTextAsync(string rawText, string systemPrompt)
        {
            var fullPrompt =
                $"{systemPrompt}\n\n" +
                $"You MUST return ONLY a single valid JSON object matching this exact structure — no markdown, no code fences, no explanation:\n" +
                $"{{\"RequiresManualReview\": <bool>, \"DocumentCategory\": \"<string>\", \"ExtractedData\": {{\"<key>\": \"<value>\"}}}}\n\n" +
                $"Document to analyze:\n{rawText}";

            var chatRequest = new ChatRequest
            {
                Model = ModelName,
                Stream = false,
                Messages =
                [
                    new Message { Role = ChatRole.System, Content = systemPrompt },
                    new Message { Role = ChatRole.User,   Content = fullPrompt   }
                ]
            };

            var responseBuilder = new StringBuilder();

            await foreach (var chunk in _ollamaClient.ChatAsync(chatRequest))
            {
                if (chunk?.Message?.Content is not null)
                    responseBuilder.Append(chunk.Message.Content);
            }

            var rawJson = responseBuilder.ToString().Trim();

            try
            {
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var result = JsonSerializer.Deserialize<ProcessedDocument>(rawJson, options);

                return result ?? new ProcessedDocument
                {
                    RequiresManualReview = true,
                    ExtractedData = new Dictionary<string, string>
                    {
                        { "error", "AI returned a null deserialization result." },
                        { "raw_response", rawJson }
                    }
                };
            }
            catch (JsonException ex)
            {
                return new ProcessedDocument
                {
                    RequiresManualReview = true,
                    ExtractedData = new Dictionary<string, string>
                    {
                        { "error", $"AI returned malformed JSON: {ex.Message}" },
                        { "raw_response", rawJson }
                    }
                };
            }
        }
    }
}
