using Contracts.DTO;
using Contracts.Interface.IService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }

        // POST api/<LoginController>
        [HttpPost]
        public LoginInfoDTO Login ([FromBody] string username, string password)
        {
            return _userService.Login(username, password);
        }
    }
}
