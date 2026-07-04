using AutoMapper;
using System;
using System.Text;
using System.Security.Claims;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Entities.DTOs.Auth;
using Entities.Concrete.Auth;
using Core.Utilities.Constants;
using Core.Utilities.Result.Concrete;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]

public class AuthenticationController : ControllerBase
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<IdentityRole<Guid>> _roleManager;
    private readonly IMapper _mapper;
    private readonly IConfiguration _configuration;
    private readonly Entities.Concrete.Auth.TokenOptions _tokenOptions;

    public AuthenticationController(
        UserManager<AppUser> userManager, 
        RoleManager<IdentityRole<Guid>> roleManager, 
        IMapper mapper, 
        IConfiguration configuration
    )
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _mapper = mapper;
        _configuration = configuration;
        _tokenOptions = configuration.GetSection("TokenOptions").Get<Entities.Concrete.Auth.TokenOptions>();

    }
    
    [HttpPost]
    public async Task<IActionResult> Register(RegisterDto register)
    {
        var user = _mapper.Map<AppUser>(register);

        var addedUser = await _userManager.CreateAsync(user, register.Password);
        if(!addedUser.Succeeded)
        {
            return BadRequest(new ErrorResult(message:addedUser.Errors.ToString()));
        }

        string newRoleName = "User";
        if(!await _roleManager.RoleExistsAsync("User"))
        {
            var addedRole = await _roleManager.CreateAsync(new IdentityRole<Guid>(newRoleName));
            if(!addedRole.Succeeded)
            {
                return BadRequest(new ErrorResult(message:addedRole.Errors.ToString()));
            }
        }

        await _userManager.AddToRoleAsync(user, newRoleName);

        return Ok(new SuccessResult(message:ResultMessages.Registered));
    }
    
    [HttpPost]
    public async Task<IActionResult> Login(LoginDto login)
    {
        var user = await _userManager.FindByNameAsync(login.UserName);
        if(user == null)
        {
            return NotFound(new ErrorDataResult<dynamic>(message:ResultMessages.NoMatchFound, data:new {}));
        }

        if(! await _userManager.CheckPasswordAsync(user, login.Password))
        {
            return Unauthorized(new ErrorDataResult<object>(message:ResultMessages.Unauthorized, data:new {}));
        }
        
        SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
        SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        JwtHeader header = new JwtHeader(signingCredentials);
        List<Claim> claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim("FirstName", user.FirstName),
            new Claim("LastName", user.LastName),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.Email, user.Email)
        };
        foreach(var role in await _userManager.GetRolesAsync(user))
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }
        JwtPayload payload = new JwtPayload(
            issuer: _tokenOptions.Issuer,
            audience: _tokenOptions.Audience,
            claims: claims,
            notBefore: DateTime.UtcNow,
            expires: DateTime.UtcNow.AddHours(_tokenOptions.AccessTokenExpiration)
        );
        JwtSecurityToken token = new JwtSecurityToken(header, payload);
        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
        string jwt = tokenHandler.WriteToken(token);

        return Ok(new SuccessDataResult<object>(
            data:new {
                Token=jwt,
                Expires=DateTime.UtcNow.AddHours(_tokenOptions.AccessTokenExpiration)
            },
            message:ResultMessages.LoggedIn
        ));
    }
    
    [HttpPatch]
    public async Task<IActionResult> Reset()
    {
        return Ok();
    }
    
    [HttpPost]
    public async Task<IActionResult> Logout()
    {
        return Ok();
    }
    
    [HttpDelete]
    public async Task<IActionResult> Remove()
    {
        return Ok();
    }
}
