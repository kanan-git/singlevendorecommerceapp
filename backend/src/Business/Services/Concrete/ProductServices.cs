using AutoMapper;
using Business.Services.Abstract;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;
using Entities.DTOs.Product;

namespace Business.Services.Concrete;

public class ProductServices : IProductServices
{
    private readonly IProductRepository _productRepo;
    private readonly IMapper _mapper;
    public ProductServices(IProductRepository productRepo, IMapper mapper)
    {
        _productRepo = productRepo;
        _mapper = mapper;
    }

    public async Task<List<ProductResponseDto>> GetAllProductsAsync()
    {
        var products = await _productRepo.GetAllProductsAsync();
        return _mapper.Map<List<ProductResponseDto>>(products);
    }

    public async Task<ProductResponseDto> GetProductByIdAsync(Guid id)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        return _mapper.Map<ProductResponseDto>(product);
    }

    public async Task AddNewProductAsync(ProductCreateDto createDto)
    {
        var newProduct = _mapper.Map<Product>(createDto);
        await _productRepo.AddProductAsync(newProduct);
        await _productRepo.SaveProductChangesAsync();
    }

    public async Task UpdateProduct(Guid id, ProductUpdateDto updateDto)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        _mapper.Map(updateDto, product);
        _productRepo.UpdateProduct(product);
        await _productRepo.SaveProductChangesAsync();
    }

    public async Task<ProductResponseDto> DeleteProduct(Guid id)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        _productRepo.DeleteProduct(product);
        await _productRepo.SaveProductChangesAsync();
        return _mapper.Map<ProductResponseDto>(product);
    }
}
