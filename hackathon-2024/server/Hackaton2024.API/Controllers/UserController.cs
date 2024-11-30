using Hackaton2024.API.Models.DTOs;
using Hackaton2024.API.Services;
using Hackaton2024.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton2024.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDTO>> GetActivities([FromRoute] int userId)
        {
            var user = await _userService.GetUser(userId);
            return Ok(user);
        }
    }
}
