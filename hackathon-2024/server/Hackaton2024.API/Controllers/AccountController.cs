using Hackaton2024.API.Models.DTOs;
using Hackaton2024.API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Hackaton2024.API.Controllers;

[Route("api/account")]
[ApiController]
//[Authorize]
public class AccountController : ControllerBase
{
    private readonly IAccountService _service;

    public AccountController(IAccountService service)
    {
        _service = service;
    }

    [HttpPost("register")]
    public async Task<ActionResult> RegisterUser([FromBody] RegisterUserDTO dto)
    {
        await _service.RegisterUser(dto);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<ActionResult<LoginResultDTO>> Login([FromBody] LoginUserDTO login)
    {
        string token = await _service.GenerateJwt(login);
        int id = await _service.GetUserId(login);
        var result = new LoginResultDTO() { Id = id, JWT = token };
        return Ok(result);
    }
}
