using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Brand;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BrandsController : ControllerBase
{
    private readonly IBrandServices _brandService;
    public BrandsController(IBrandServices brandService)
    {
        _brandService = brandService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllBrands()
    {
        var data = await _brandService.GetAllBrandsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllBrandsPaginated(int page, int size)
    {
        var data = await _brandService.GetAllBrandsPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBrandById(Guid id)
    {
        var data = await _brandService.GetBrandByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateBrand(BrandCreateDto brandDto)
    {
        var result = await _brandService.AddNewBrandAsync(brandDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateBrand(Guid id, BrandUpdateDto brandDto)
    {
        var result = await _brandService.UpdateBrand(id, brandDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveBrand(Guid id)
    {
        var result = await _brandService.DeleteBrand(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
