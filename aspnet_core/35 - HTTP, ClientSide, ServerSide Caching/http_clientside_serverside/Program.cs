var builder = WebApplication.CreateBuilder(args);

builder.Services.AddResponseCaching();      // Add HTTP Caching
builder.Services.AddMemoryCache();          // Add Server-Side Cache

var app = builder.Build();

app.UseResponseCaching();                   // Use HTTP Caching

app.MapGet("/", () => "Hello World!");

app.Run();
