using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Coupon;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CouponsController : ControllerBase
{
    private readonly ICouponServices _couponService;
    public CouponsController(ICouponServices couponService)
    {
        _couponService = couponService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCoupons()
    {
        var data = await _couponService.GetAllCouponsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllCouponsPaginated(int page, int size)
    {
        var data = await _couponService.GetAllCouponsPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCouponById(Guid id)
    {
        var data = await _couponService.GetCouponByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreateCoupon(CouponCreateDto couponDto)
    {
        var result = await _couponService.AddNewCouponAsync(couponDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCoupon(Guid id, CouponUpdateDto couponDto)
    {
        var result = await _couponService.UpdateCoupon(id, couponDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveCoupon(Guid id)
    {
        var result = await _couponService.DeleteCoupon(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
