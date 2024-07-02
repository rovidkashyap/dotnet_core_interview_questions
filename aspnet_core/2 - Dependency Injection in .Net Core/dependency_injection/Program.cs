var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient<IMyService, MyService>();
//builder.Services.AddScoped<IOtherService, OtherService>();
//builder.Services.AddSingleton<IAnotherService, AnotherService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
