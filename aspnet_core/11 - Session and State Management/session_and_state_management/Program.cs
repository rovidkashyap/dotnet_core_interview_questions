var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Adds a default in-memory implementation of IDisstributedCache
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set Session Timeout
    options.Cookie.HttpOnly = true;                 // Make the session cookie HTTP-only
    options.Cookie.IsEssential = true;              // Make the session cookie essential
});

app.UseSession();                                   // Add Session Middleware

app.MapGet("/", () => "Hello World!");

app.Run();
