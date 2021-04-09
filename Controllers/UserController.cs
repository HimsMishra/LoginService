using LoginService.Repository;
using Microsoft.AspNetCore.Mvc;
using LoginService.Models;

namespace LoginService.Controllers
{
    [ApiController]
   [Route("[controller]")]
    public class UserController : ControllerBase
    {
        IUserRepository userRepository;
        public UserController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        [HttpPost("Create")]
        public ActionResult CreateUser(User user)
        {
            return Ok(this.userRepository.createUser(user));
        }

        
        [HttpPost("Validate")]
        public ActionResult ValidateUser(User user)
        {
            return Ok(this.userRepository.LoginValidate(user.userName,user.password));
        }
    }
}