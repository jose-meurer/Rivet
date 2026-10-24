var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/v1/catalog", () => new
{
    Name = "Catálogo Rivet"
});

app.Run();
