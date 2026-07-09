using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Address;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class AddresssController : ControllerBase
{
    private readonly IAddressServices _addressService;
    public AddresssController(IAddressServices addressService)
    {
        _addressService = addressService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAddresss()
    {
        var data = await _addressService.GetAllAddressesAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllAddresssPaginated(int page, int size)
    {
        var data = await _addressService.GetAllAddressesPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAddressById(Guid id)
    {
        var data = await _addressService.GetAddressByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateAddress(AddressCreateDto addressDto)
    {
        var result = await _addressService.AddNewAddressAsync(addressDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAddress(Guid id, AddressUpdateDto addressDto)
    {
        var result = await _addressService.UpdateAddress(id, addressDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveAddress(Guid id)
    {
        var result = await _addressService.DeleteAddress(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
