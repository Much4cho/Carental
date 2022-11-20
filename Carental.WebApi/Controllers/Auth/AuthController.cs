using Microsoft.AspNetCore.Mvc;

namespace Carental.WebApi.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public User Get()
        {
            return new User
            {
                Email = "test@example.com",
                Password = "test",
            };
        }
    }
}
