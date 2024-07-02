var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();          // Setup In-Memory Cache and Use it in Controller.

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
