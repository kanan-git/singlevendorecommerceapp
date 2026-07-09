using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Language;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class LanguagesController : ControllerBase
{
    private readonly ILanguageServices _languageService;
    public LanguagesController(ILanguageServices languageService)
    {
        _languageService = languageService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllLanguages()
    {
        var data = await _languageService.GetAllLanguagesAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllLanguagesPaginated(int page, int size)
    {
        var data = await _languageService.GetAllLanguagesPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetLanguageById(Guid id)
    {
        var data = await _languageService.GetLanguageByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateLanguage(LanguageCreateDto languageDto)
    {
        var result = await _languageService.AddNewLanguageAsync(languageDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateLanguage(Guid id, LanguageUpdateDto languageDto)
    {
        var result = await _languageService.UpdateLanguage(id, languageDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveLanguage(Guid id)
    {
        var result = await _languageService.DeleteLanguage(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
