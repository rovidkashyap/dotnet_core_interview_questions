var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();               // Use Convention-Based Routing

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


