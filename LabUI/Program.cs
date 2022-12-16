using ClientApi.Services;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// The API calls will move eventually to the appropriate spots in the web ui

var apiUrl = builder.Configuration["LABWORK_API_URL"];
var httpClient = new HttpClient();

var output = "Something went wrong.";

try
{
    var client = new LabClient(apiUrl, httpClient);
    var labwork = await client.LabRecordsAsync();
    output = FormatLabwork(labwork);

}
catch (System.Net.Http.HttpRequestException ex)
{
    var message = "The labwork data appears to be unavailable.";
    // in a real-word app, graceful retries would be helpful here
    Console.Error.WriteLine(message);
    Console.Error.WriteLine(ex.ToString());

    output = message;
}


// for now, we're dumping the results of each api call to the browser

app.MapGet("/", () => "Lab Demo User Interface\n" + string.Join("\n", output));

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
