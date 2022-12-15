using ClientApi.Services;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var apiUrl = builder.Configuration["LABWORK_API_URL"];
var httpClient = new HttpClient();
var client = new LabClient(apiUrl, httpClient);
var labwork = await client.GetLabworkAsync();

app.MapGet("/", () => "Lab Demo User Interface" + labwork.ToString());

app.Run();
