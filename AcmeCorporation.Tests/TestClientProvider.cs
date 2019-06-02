using AcmeCorporationAPI;
using Contracts;
using Entities.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Xunit;

namespace AcmeCorporation.Tests
{
    public class TestClientProvider : IDisposable
    {
        public TestServer server;
        public HttpClient _client { get; private set; }
        public TestClientProvider()
        {
            server = new TestServer(new WebHostBuilder().UseStartup<Startup>());

            _client = server.CreateClient();
        }

        public void Dispose()
        {
            server?.Dispose();
            _client?.Dispose();
        }

        //[Fact]
        //public void TicketGetAllTest()
        //{
        //    //Arrange
        //    var request = new HttpRequestMessage(new HttpMethod("GetAll"), "http://localhost:2263/api/ticket");

        //    //Act
        //    var response = _client.SendAsync(request).Result;

        //    //Assert
        //    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        //}

        //[Fact]
        //public void ProductGet100Test()
        //{
        //    var okResult = _unitOfWork.ProductRepository.GetAll() as OkObjectResult;

        //    var items = Assert.IsType<List<Product>>(okResult.Value);
        //    Assert.Equal(100, items.Count);
        //}
    }
}
