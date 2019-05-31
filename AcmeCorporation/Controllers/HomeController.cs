using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Entities.Data;
using Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AcmeCorporation.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        private readonly DataContext _db;
        private readonly HttpClient _client;
        private Uri BaseEndPoint { get; set; }
        public HomeController(DataContext db)
        {
            BaseEndPoint = new Uri("http://localhost:2263/api/product");
            _client = new HttpClient();
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _client.GetAsync(BaseEndPoint, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return View(JsonConvert.DeserializeObject<List<Product>>(data));
        }
    }
}