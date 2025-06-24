using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace Accountant.Api.Tests
{
    public class ApiIntegrationTests : IClassFixture<WebApplicationFactory<Accountant.Api.Program>>
    {
        private readonly HttpClient _client;
        public ApiIntegrationTests(WebApplicationFactory<Accountant.Api.Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Get_WeatherForecast_ReturnsSuccess()
        {
            var response = await _client.GetAsync("/weatherforecast");
            response.EnsureSuccessStatusCode();
        }
    }

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
    }
}