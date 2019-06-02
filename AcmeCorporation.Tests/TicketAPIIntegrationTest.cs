using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AcmeCorporation.Tests
{
    public class TicketAPIIntegrationTest
    {
        [Fact]
        public async Task GetAllTest()
        {
            var client = new TestClientProvider()._client;

            var response = await client.GetAsync("http://localhost:2263/api/ticket");

            response.EnsureSuccessStatusCode();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
