using ClientApi.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// The API calls will move eventually to the appropriate spots in the web ui

var apiUrl = builder.Configuration["LABWORK_API_URL"];
var httpClient = new HttpClient();
var client = new LabClient(apiUrl, httpClient);
var labwork = await client.GetLabworkAsync();
var formattedLabwork = FormatLabwork(labwork);

// for now, we're dumping the results of each api call to the browser

app.MapGet("/", () => "Lab Demo User Interface" + string.Join("\n", formattedLabwork));

app.Run();

public static partial class Program
{
    public static string FormatLabwork(ICollection<FlattenedLabRecord> labs)
    {
        return string.Join("\n", labs.Select(x =>
                    string.Format("\n{0}: {1} - {2} {3}",
                    x.DateMeasured, x.Name, x.Value, x.Units)));
    }
}
