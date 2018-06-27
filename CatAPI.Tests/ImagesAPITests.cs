using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CatAPI.Tests
{
    public class ImagesAPITests
    {
        private readonly TestServer _testServer;
        private readonly HttpClient _client;

        public ImagesAPITests()
        {
            _testServer = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = _testServer.CreateClient();
        }

        [Fact]
        public async Task ImagesAPI_WhenCategoriesStringIsLessthen3Letters_RetrurnBadRequest()
        {
            var expectedStatusCode = "BadRequest";
            var path = "api/images/get?format=xml&results_per_page={page_count}&category=ha";
            var response = await _client.GetAsync(path);
            var statusCode =  response.StatusCode.ToString();
            Assert.Equal(expectedStatusCode, statusCode);
        }

    }
}
