using Microsoft.AspNetCore.Mvc;
using Reservation.Application.Contract.Dtos.Users;
using Reservation.Application.Contract.IServices.Users;

namespace Reservation.EndPoint.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDto dto)
         {
            string token = userService.Login(dto);
            return Ok(token);
        }

        [HttpPost("[action]")]
        public IActionResult Register(RegisterDto dto)
        {
            userService.Register(dto);
            return Ok();
        }
    }
}
