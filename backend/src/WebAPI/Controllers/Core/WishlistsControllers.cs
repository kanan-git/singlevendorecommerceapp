using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Wishlist;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class WishlistsController : ControllerBase
{
    private readonly IWishlistServices _wishlistService;
    public WishlistsController(IWishlistServices wishlistService)
    {
        _wishlistService = wishlistService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllWishlists()
    {
        var data = await _wishlistService.GetAllWishlistsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllWishlistsPaginated(int page, int size)
    {
        var data = await _wishlistService.GetAllWishlistsPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetWishlistById(Guid id)
    {
        var data = await _wishlistService.GetWishlistByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateWishlist(WishlistCreateDto wishlistDto)
    {
        var result = await _wishlistService.AddNewWishlistAsync(wishlistDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateWishlist(Guid id, WishlistUpdateDto wishlistDto)
    {
        var result = await _wishlistService.UpdateWishlist(id, wishlistDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveWishlist(Guid id)
    {
        var result = await _wishlistService.DeleteWishlist(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
