var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var produtos = new List<string> { "Caneta", "Caderno" };

app.MapGet("/produtos", () => produtos);

app.MapPost("/produtos", (string nome) =>
{
    produtos.Add(nome);
    return Results.Created($"/produtos/{nome}", nome);
});

app.Run();
