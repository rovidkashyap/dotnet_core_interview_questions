var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    // Pre-processing logic before the next middleware or request handler
    await context.Response.WriteAsync("Hello from middleware 1!");

    await next.Invoke();    // Call the next middleware in the pipeline

    // Post-processing logic after the next middleware or request handler
    await context.Response.WriteAsync("Goodbye from middleware 1!");

});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from middleware 2!");
    await next.Invoke();
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Hello from terminal middleware!");
});

