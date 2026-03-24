using DocumentProcessor.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPromptFactory, PromptFactory>();
builder.Services.AddScoped<ILocalAiProvider, OllamaProvider>();
builder.Services.AddScoped<DocumentProcessingService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/api/process", async (ProcessDocumentRequest request, DocumentProcessingService service) =>
{
    var result = await service.ProcessDocumentAsync(request.Text, request.Category);
    return Results.Ok(result);
})
.WithName("ProcessDocument")
.WithOpenApi();

app.Run();

record ProcessDocumentRequest(string Text, string Category);
