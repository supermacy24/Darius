var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => new
{
    name = "Darius",
    status = "running"
});

app.MapGet("/health", () => Results.Ok(new
{
    status = "healthy"
}));

app.Run();