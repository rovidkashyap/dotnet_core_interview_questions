var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();                      // Redirect HTTP requests to HTTPS
app.UseStaticFiles();                           // Serves static files
app.UseRouting();                               // Adds routing capabilities

app.UseAuthentication();                        // Adds authentication capabilities
app.UseAuthorization();                         // Adds authorization capabilities

app.MapGet("/", () => "Hello World!");

app.Run();
