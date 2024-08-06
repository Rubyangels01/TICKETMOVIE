using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TICKETMOVIE.Service
{
    public class UserService : IMovieService
    {
        public UserService()
        {

        }
        

        public (string url, StringContent content) UrlLogin(string email, string password)
        {
            string url = "manager/login";
            var content = new StringContent(
                $"{{ \"Email\": \"{email}\", \"PassWord\": \"{password}\" }}",
                Encoding.UTF8,
                "application/json");
            return (url, content);
        }
        public String UrlGetTheaterByUser(string email)
        {
            return $"theater/user/{email}";
        }
    }
    
    
}
