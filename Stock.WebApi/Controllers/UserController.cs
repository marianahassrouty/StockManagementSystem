using Microsoft.AspNetCore.Mvc;
using Stock.Application.Users.Dtos;
using Stock.Application.Users.Interfaces;
using Stock.Domain.Users.Entities;

namespace Stock.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequestDto dto)
    {
        User? user = await userService.LoginAsync(dto.Email, dto.Password);
        if (user == null)
            return Unauthorized("Invalid email or password.");

        return Ok(new
        {
            user.Id,
            user.Name,
            user.Email,
            user.IsAdmin
        });
    }
}
