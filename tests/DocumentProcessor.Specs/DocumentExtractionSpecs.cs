using System.Collections.Generic;
using FluentAssertions;
using Moq;
using Xunit;
using DocumentProcessor.Api.Services;
using DocumentProcessor.Api.Models;

namespace DocumentProcessor.Specs;

public class DocumentProcessingSpecs
{
    [Fact]
    public async Task ProcessDocument_Legal_Should_Extract_Clause_And_Flag_Review()
    {
        // Arrange
        var mockAiProvider = new Mock<ILocalAiProvider>();
        var mockPromptFactory = new Mock<IPromptFactory>();
        var service = new DocumentProcessingService(mockAiProvider.Object, mockPromptFactory.Object);

        var rawLegalDocument = "This agreement includes an indemnity clause binding both parties.";
        var documentCategory = "Legal";
        var dummySystemPrompt = "LEGAL_SYSTEM_PROMPT";

        mockPromptFactory
            .Setup(f => f.GetSystemPrompt(documentCategory))
            .Returns(dummySystemPrompt);

        // We mock the AI response for the spec to keep tests lightning fast
        mockAiProvider
            .Setup(ai => ai.AnalyzeTextAsync(rawLegalDocument, dummySystemPrompt))
            .ReturnsAsync(new ProcessedDocument
            {
                RequiresManualReview = true,
                DocumentCategory = "Legal",
                ExtractedData = new Dictionary<string, string>
                {
                    { "Clause", "Indemnity" }
                }
            });

        // Act
        var result = await service.ProcessDocumentAsync(rawLegalDocument, documentCategory);

        // Assert
        result.Should().NotBeNull();
        result.RequiresManualReview.Should().BeTrue();
        result.ExtractedData.Should().ContainKey("Clause")
            .WhoseValue.Should().Be("Indemnity");
    }
}