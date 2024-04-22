using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LoginApi.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Authorization;

namespace LoginApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public Responses Login(Users users)
        {
            if (users.username == "semih" && users.password == "123")
            {
                return new Responses()
                {
                    Message = "Login işlemi başarılı.",
                    Code = "200",
                    Data = null
                };
            }

            return new Responses()
            {
                Message = "Login işlemi başarısız.",
                Code = "401",
                Data = null
            };

        }

    }
}
