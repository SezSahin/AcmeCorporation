using Entities.Model;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace RestService
{
    public class RestService : IRestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public List<Product> Items { get; private set; }

        public async Task<List<Product>> GetProductsAsync()
        {
            var uri = new Uri(string.Format(Constants.GetProductUrl, string.Empty));
            var response = await _client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<Product>>(content);
            }
            return null;
        }

        //public async Task<ApplicationUser> Login(LoginModel item)
        //{
        //    var uri = new Uri(Constants.LoginUrl);

        //    var response = await _client.PostAsync(uri, GetContent(item));
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseContent = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<ApplicationUser>(responseContent);
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}

        //public async Task<ApplicationUser> Register(RegisterModel item)
        //{
        //    var uri = new Uri(Constants.RegisterUrl);

        //    var response = await _client.PostAsync(uri, GetContent(item));
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseContent = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<ApplicationUser>(responseContent);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public async Task<ApplicationUser> GetUserAsync(string id)
        //{
        //    var uri = new Uri(Constants.GetUsersUrl + "/" + id.ToString());
        //    var response = await _client.GetAsync(uri);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseContent = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<ApplicationUser>(responseContent);
        //    }
        //    return null;
        //}

        //public async Task<List<ApplicationUser>> GetUsersAsync()
        //{
        //    var uri = new Uri(Constants.GetUsersUrl);

        //    var response = await _client.GetAsync(uri);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseContent = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<List<ApplicationUser>>(responseContent);
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public async void UpdateUserAsync(ApplicationUserDTO item)
        //{
        //    var uri = new Uri(Constants.UpdateUserUrl + item.Id.ToString());

        //    var response = await _client.PostAsync(uri, GetContent(item));
        //}

        //private StringContent GetContent(object item)
        //{
        //    var json = JsonConvert.SerializeObject(item);
        //    return new StringContent(json, Encoding.UTF8, "application/json");
        //}
    }
}
