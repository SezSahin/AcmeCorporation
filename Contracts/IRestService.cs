using Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRestService
    {
        Task<List<Product>> GetProductsAsync();


        //Task<ApplicationUser> Login(LoginModel item);
        //Task<List<ApplicationUser>> GetUsersAsync();

        //Task<ApplicationUser> Register(RegisterModel item);

        //Task<ApplicationUser> GetUserAsync(string id);

        //void UpdateUserAsync(ApplicationUserDTO item);
    }
}
