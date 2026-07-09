using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.CartItem;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CartItemsController : ControllerBase
{
    private readonly ICartItemServices _cartItemService;
    public CartItemsController(ICartItemServices cartItemService)
    {
        _cartItemService = cartItemService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCartItems()
    {
        var data = await _cartItemService.GetAllCartItemsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllCartItemsPaginated(int page, int size)
    {
        var data = await _cartItemService.GetAllCartItemsPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCartItemById(Guid id)
    {
        var data = await _cartItemService.GetCartItemByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateCartItem(CartItemCreateDto cartItemDto)
    {
        var result = await _cartItemService.AddNewCartItemAsync(cartItemDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCartItem(Guid id, CartItemUpdateDto cartItemDto)
    {
        var result = await _cartItemService.UpdateCartItem(id, cartItemDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveCartItem(Guid id)
    {
        var result = await _cartItemService.DeleteCartItem(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
