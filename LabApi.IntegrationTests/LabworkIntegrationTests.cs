using Xunit;
using Shouldly;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;

using LabAPI;
using Microsoft.AspNetCore.Builder;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Hosting;

namespace LabApi.IntegrationTests
{
    public class LabworkIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        class TestVersionOfApplication : WebApplicationFactory<Program>
        {
            protected override IHost CreateHost(IHostBuilder builder)
            {
                return base.CreateHost(builder);
            }
        }

        public LabworkIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public void GetLabwork_ShouldBeOk()
        {
            var app = new TestVersionOfApplication();
            var client = app.CreateClient();
            
            var request = new HttpRequestMessage(new HttpMethod("GET"), "/Labwork");
            var response = client.Send(request);
        }

        //public class TestStartup
        //{
        //    public static WebApplicationBuilder Configure(WebApplicationBuilder webAppBuilder)
        //    {
        //        webAppBuilder.SetupApp();
        //        return webAppBuilder;
        //    }
        //}

        //public LabworkIntegrationTests()
        //{
        //    var server = new TestServer(new WebHostBuilder()
        //        // CONSIDER:
        //        .UseEnvironment("Development")
        //        .UseStartup<TestStartup>()
        //        .ConfigureServices(services => LabAPI.HostBuilderExtensions.BuildServices(services))
        //        );

        //    _client = server.CreateClient();
        //}

        //[Fact]
        //public void GetLabwork_ShouldBeOk()
        //{
        //    var request = new HttpRequestMessage(new HttpMethod("GET"), "/Labwork");

        //    var response = _client.Send(request);

        //    response.EnsureSuccessStatusCode();
        //    response.StatusCode.ShouldBe(System.Net.HttpStatusCode.OK);
        //}

        //[Fact]
        //public void GetFoo_ShouldNotBeFound()
        //{
        //    var request = new HttpRequestMessage(new HttpMethod("GET"), "/Foo");

        //    var response = _client.Send(request);

        //    response.EnsureSuccessStatusCode();
        //    response.StatusCode.ShouldBe(System.Net.HttpStatusCode.NotFound);
        //}
    }
}