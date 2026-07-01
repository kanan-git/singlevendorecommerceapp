using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.ContextDB.EFCore;
using Entities.Concrete.Core;
using Entities.DTOs.Product;

namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductsController : ControllerBase
{
    private readonly ECommerceDbContext _dbContext;
    private readonly IMapper _mapper;
    public ProductsController(ECommerceDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await _dbContext.Products.ToListAsync();
        var dtos = _mapper.Map<List<ProductResponseDto>>(products);
        return Ok(dtos);
    }

    [HttpPost]
    public async Task<IActionResult> CreateProduct(ProductCreateDto productDto)
    {
        var NewProduct = _mapper.Map<Product>(productDto);
        _dbContext.Products.Add(NewProduct);
        await _dbContext.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAllProducts), NewProduct);
    }
}
