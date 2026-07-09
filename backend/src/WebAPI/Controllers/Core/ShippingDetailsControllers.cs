using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.ShippingDetail;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ShippingDetailsController : ControllerBase
{
    private readonly IShippingDetailServices _shippingDetailsService;
    public ShippingDetailsController(IShippingDetailServices shippingDetailsService)
    {
        _shippingDetailsService = shippingDetailsService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllShippingDetails()
    {
        var data = await _shippingDetailsService.GetAllShippingDetailsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllShippingDetailsPaginated(int page, int size)
    {
        var data = await _shippingDetailsService.GetAllShippingDetailsPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetShippingDetailById(Guid id)
    {
        var data = await _shippingDetailsService.GetShippingDetailByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateShippingDetail(ShippingDetailCreateDto shippingDetailsDto)
    {
        var result = await _shippingDetailsService.AddNewShippingDetailAsync(shippingDetailsDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateShippingDetail(Guid id, ShippingDetailUpdateDto shippingDetailsDto)
    {
        var result = await _shippingDetailsService.UpdateShippingDetail(id, shippingDetailsDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveShippingDetail(Guid id)
    {
        var result = await _shippingDetailsService.DeleteShippingDetail(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
