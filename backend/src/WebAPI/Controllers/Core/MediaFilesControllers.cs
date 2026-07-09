using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]

public class MediaFilesController : ControllerBase
{
    private readonly IMediaFileServices _mediaFileServices;
    public MediaFilesController(IMediaFileServices mediaFileServices)
    {
        _mediaFileServices = mediaFileServices;
    }

    [HttpPost]
    public async Task<IActionResult> Upload()
    {
        // CREATE, FILE STREAM, SAVE FILE & DATA
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Download()
    {
        // READ, FILE STREAM, GET FILE & DATA
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Edit()
    {
        // UPDATE, FILE STREAM?, EDIT FILE DATA &/ FILE
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Remove()
    {
        // DELETE, REMOVE DATA & FILE
        return Ok();
    }
}
