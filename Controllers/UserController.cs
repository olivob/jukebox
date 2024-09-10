using Microsoft.AspNetCore.Mvc;

namespace Jukebox.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService; 

        public UserController(IUserService userservice)
        {
            _userService = userservice;
        }
    }
}