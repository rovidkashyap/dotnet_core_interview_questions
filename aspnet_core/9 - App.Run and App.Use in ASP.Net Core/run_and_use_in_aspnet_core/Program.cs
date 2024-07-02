var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Example middleware using App.Use

app.Use(async (context, next) =>
{
    // Middleware logic before the next middleware
    await context.Response.WriteAsync("Before 1st Middleware\n");

    // Calling the next middleware in the pipeline
    await next.Invoke();

    // Middleware logic after the next middleware
    await context.Response.WriteAsync("After 1st Middleware\n");
});

app.Use(async (context, next) =>
{
    // Middleware logic for the second middleware
    await context.Response.WriteAsync("Inside 2nd Middleware\n");

    // call the next middleware in the pipeline
    await next.Invoke();
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Inside Run Middleware\n");
});

app.MapGet("/", () => "Hello World!");

app.Run();
