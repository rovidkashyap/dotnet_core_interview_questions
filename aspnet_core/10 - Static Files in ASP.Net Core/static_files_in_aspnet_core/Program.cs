var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

// Enabling static file serving
app.UseStaticFiles();

// Other middleware configuration...
