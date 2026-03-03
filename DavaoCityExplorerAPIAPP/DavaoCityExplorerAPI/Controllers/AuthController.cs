using DavaoCityExplorerAPI.Data;
using DavaoCityExplorerAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DavaoCityExplorerAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _config;

    public AuthController(ApplicationDbContext context, IConfiguration config)
    {
        _context = context;
        _config = config;
    }

    [HttpPost("register")]
    public async Task<ActionResult<string>> Register(UserDto request)
    {
        if (await _context.Users.AnyAsync(u => u.Email == request.Email))
        {
            return BadRequest("User already exists.");
        }

        string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

        var user = new UserModel
        {
            Email = request.Email,
            PasswordHash = passwordHash,

            FirstName = request.FirstName,
            LastName = request.LastName,

            Role = "User"
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok("User successfully registered");

    }

    [HttpPost("login")]
    public async Task<ActionResult<string>> Login(UserDto request)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);

        if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
        {
            return BadRequest("Wrong email or password.");
        }

        string token = CreateToken(user);

        return Ok(token);
    }

    private string CreateToken(UserModel user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()),
            new Claim(ClaimTypes.GivenName, user.FirstName),
            new Claim(ClaimTypes.Surname, user.LastName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(1),
            SigningCredentials = creds,
            Issuer = _config["Jwt:Issuer"],
            Audience = _config["Jwt:Audience"]
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);
        
        return tokenHandler.WriteToken(token);
    }

    [Authorize]
    [HttpGet("me")]
    public ActionResult GetUserProfile()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        var firstName = User.FindFirstValue(ClaimTypes.GivenName);
        var lastName = User.FindFirstValue(ClaimTypes.Surname);
        var email = User.FindFirstValue(ClaimTypes.Email);
        var role = User.FindFirstValue(ClaimTypes.Role);

        return Ok(new
        {
            Id = userId,
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Role = role
        });

    }
}
