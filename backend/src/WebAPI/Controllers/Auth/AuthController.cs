using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]

public class AuthController : ControllerBase
{
    public AuthController()
    {}

    [HttpPost]
    public async Task<IActionResult> Register()
    {
        return Ok();
    }
    
    [HttpPost]
    public async Task<IActionResult> Login()
    {
        return Ok();
    }
    
    [HttpPut]
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
