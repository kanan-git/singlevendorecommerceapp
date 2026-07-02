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
        return Ok(new {
            Status = 200,
            Data = data,
            Message = ""
        });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(Guid id)
    {
        var data = await _productService.GetProductByIdAsync(id);
        return Ok(new {
            Status = 200,
            Data = data,
            Message = ""
        });
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductCreateDto productDto)
    {
        await _productService.AddNewProductAsync(productDto);
        return Ok(new {
            Status = 201,
            Data = productDto,
            Message = ""
        });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(Guid id, ProductUpdateDto productDto)
    {
        await _productService.UpdateProduct(id, productDto);
        return Ok(new {
            Status = 200,
            Data = productDto,
            Message = ""
        });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveProduct(Guid id)
    {
        var data = await _productService.DeleteProduct(id);
        return Ok(new {
            Status = 200,
            Data = data,
            Message = ""
        });
    }
}
