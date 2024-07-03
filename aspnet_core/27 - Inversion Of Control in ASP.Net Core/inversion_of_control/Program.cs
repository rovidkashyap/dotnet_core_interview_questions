using inversion_of_control.Interfaces;
using inversion_of_control.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<IMessageService, MessageService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
