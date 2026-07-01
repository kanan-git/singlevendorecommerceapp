using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Repositories.Abstract;
using Entities.DTOs.Product;
using Entities.Concrete.Core;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepo;
    private readonly IMapper _mapper;
    public ProductsController(IProductRepository productRepo, IMapper mapper)
    {
        _productRepo = productRepo;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _productRepo.GetAllProductsAsync();
        var result = _mapper.Map<List<ProductResponseDto>>(products);
        return Ok(new {
            Status = 200,
            Data = result,
            Message = ""
        });
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProductById(Guid id)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        var result = _mapper.Map<ProductResponseDto>(product);
        return Ok(new {
            Status = 200,
            Data = result,
            Message = ""
        });
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductCreateDto productDto)
    {
        var newProduct = _mapper.Map<Product>(productDto);
        await _productRepo.AddProductAsync(newProduct);
        await _productRepo.SaveProductChangesAsync();
        return Ok(new {
            Status = 201,
            Data = productDto,
            Message = ""
        });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(Guid id, ProductUpdateDto productDto)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        _mapper.Map(productDto, product);
        _productRepo.UpdateProduct(product);
        await _productRepo.SaveProductChangesAsync();
        return Ok(new {
            Status = 200,
            Data = product,
            Message = ""
        });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> RemoveProduct(Guid id)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        var deleteProduct = _mapper.Map<Product>(product);
        _productRepo.DeleteProduct(deleteProduct);
        await _productRepo.SaveProductChangesAsync();
        return Ok(new {
            Status = 200,
            Data = product,
            Message = ""
        });
    }
}
