using LabAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Configure();
builder.BuildWebServer();

var app = builder.Build();

app.SetupApp();

app.RunAsync();
