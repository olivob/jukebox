using Microsoft.AspNetCore.Mvc;

namespace Jukebox.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService; 

        public UserController(IUserService userService)
        {
            _userService = userservice;
        }

        // need to setup db context in repository and 
    }
}