using System;
using System.Collections.Generic;
using System.Text;

namespace RestService
{
    public class Constants
    {
        public const string BaseUrl = "http://10.0.2.2:50846/api/";
        public const string CreateProductUrl = BaseUrl + "product";
        public const string GetProductUrl = BaseUrl + "product";

        public const string CreateTicketUrl = BaseUrl + "ticket";
        public const string GetTicketUrl = BaseUrl + "ticket";

        public const string LoginUrl = BaseUrl + "user/login";
        public const string GetUsersUrl = BaseUrl + "user";

        public const string RegisterUrl = BaseUrl + "user/register";
        public const string UpdateUserUrl = BaseUrl + "user";
    }
}
