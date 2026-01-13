using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LifeRPG.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize] // 🔒 This makes ALL endpoints in this controller protected
public class UsersController : ControllerBase
{
    [HttpGet("me")]
    public IActionResult GetCurrentUser()
    {
        // Get user info from JWT token claims
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)
                     ?? User.FindFirstValue("sub");

        var email = User.FindFirstValue(ClaimTypes.Email);
        var username = User.FindFirstValue("username");

        return Ok(new
        {
            id = userId,
            email = email,
            username = username
        });
    }
}
