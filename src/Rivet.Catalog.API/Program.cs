using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

//app.UseHttpsRedirection();

app.MapGet("/api/v1/catalog/status", () =>
        TypedResults.Ok(new
        {
            service = "Rivet.Catalog.API",
            status = "running"
        }))
    .WithName("GetCatalogStatus");

app.Run();
