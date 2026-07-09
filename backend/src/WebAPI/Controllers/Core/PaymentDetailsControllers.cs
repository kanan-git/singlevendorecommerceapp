using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.PaymentDetail;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class PaymentDetailsController : ControllerBase
{
    private readonly IPaymentDetailServices _paymentDetailService;
    public PaymentDetailsController(IPaymentDetailServices paymentDetailService)
    {
        _paymentDetailService = paymentDetailService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPaymentDetails()
    {
        var data = await _paymentDetailService.GetAllPaymentDetailsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{page}")]
    public async Task<IActionResult> GetAllPaymentDetailsPaginated(int page, int size)
    {
        var data = await _paymentDetailService.GetAllPaymentDetailsPaginatedAsync(page, size);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPaymentDetailById(Guid id)
    {
        var data = await _paymentDetailService.GetPaymentDetailByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    [Authorize(Roles="Admin, User")]
    public async Task<IActionResult> CreatePaymentDetail(PaymentDetailCreateDto paymentDetailDto)
    {
        var result = await _paymentDetailService.AddNewPaymentDetailAsync(paymentDetailDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdatePaymentDetail(Guid id, PaymentDetailUpdateDto paymentDetailDto)
    {
        var result = await _paymentDetailService.UpdatePaymentDetail(id, paymentDetailDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemovePaymentDetail(Guid id)
    {
        var result = await _paymentDetailService.DeletePaymentDetail(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
