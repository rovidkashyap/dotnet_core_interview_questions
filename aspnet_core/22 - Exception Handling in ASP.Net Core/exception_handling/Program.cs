var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseExceptionHandler("/Error");                  // Redirect to error page or endpoint
app.UseStatusCodePagesWithReExecute("/Error/{0}");  // Handle specific status codes

app.MapGet("/", () => "Hello World!");

app.Run();
