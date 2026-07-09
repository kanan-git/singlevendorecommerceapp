using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Order;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderServices _orderService;
    public OrdersController(IOrderServices orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrders()
    {
        var data = await _orderService.GetAllOrdersAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllOrdersPaginated(int page, int size)
    {
        var data = await _orderService.GetAllOrdersPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderById(Guid id)
    {
        var data = await _orderService.GetOrderByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateOrder(OrderCreateDto orderDto)
    {
        var result = await _orderService.AddNewOrderAsync(orderDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOrder(Guid id, OrderUpdateDto orderDto)
    {
        var result = await _orderService.UpdateOrder(id, orderDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveOrder(Guid id)
    {
        var result = await _orderService.DeleteOrder(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
