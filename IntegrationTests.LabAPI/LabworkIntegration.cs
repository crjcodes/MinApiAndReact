using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;
using Shouldly;
using LabAPI;

namespace IntegrationTests.LabAPI
{
    internal class LabApiAppForTesting : WebApplicationFactory<Program>
    {
        // TODO: override as necessary for testing any configuration of the builder or the app here
    }

    public class LabworkIntegration
    {
        [Fact]
        public async Task GetLabwork_ShouldRespondOk()
        {
            var app = new LabApiAppForTesting();
            var client = app.CreateClient();
            var request = new HttpRequestMessage(new HttpMethod("GET"), "/Labwork");
            var response = await client.SendAsync(request);

            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }
    }
}