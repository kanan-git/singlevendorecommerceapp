using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Business.Services.Abstract;
using Entities.DTOs.Product;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductsController : ControllerBase
{
    private readonly IProductServices _productService;
    public ProductsController(IProductServices productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var data = await _productService.GetAllProductsAsync();
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(Guid id)
    {
        var data = await _productService.GetProductByIdAsync(id);
        if(data.Success)
        {
            return Ok(data);
        }
        return BadRequest(data);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductCreateDto productDto)
    {
        var result = await _productService.AddNewProductAsync(productDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(Guid id, ProductUpdateDto productDto)
    {
        var result = await _productService.UpdateProduct(id, productDto);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveProduct(Guid id)
    {
        var result = await _productService.DeleteProduct(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
