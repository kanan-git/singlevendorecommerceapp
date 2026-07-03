using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
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

    public async Task<IDataResult<List<ProductResponseDto>>> GetAllProductsAsync()
    {
        var products = await _productRepo.GetAllProductsAsync();
        var data = _mapper.Map<List<ProductResponseDto>>(products);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<ProductResponseDto>>(message:"404");
        }
        return new SuccessDataResult<List<ProductResponseDto>>(data:data, message:"200");
    }

    public async Task<IDataResult<ProductResponseDto>> GetProductByIdAsync(Guid id)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        if(product == null)
        {
            return new ErrorDataResult<ProductResponseDto>(message:"404");
        }
        var data = _mapper.Map<ProductResponseDto>(product);
        return new SuccessDataResult<ProductResponseDto>(data:data, message:"200");
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewProductAsync(ProductCreateDto createDto)
    {
        var newProduct = _mapper.Map<Product>(createDto);
        try{
            await _productRepo.AddProductAsync(newProduct);
            await _productRepo.SaveProductChangesAsync();
            return new SuccessResult(message:"201");
        }
        catch(Exception)
        {
            return new ErrorResult(message:"500");
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateProduct(Guid id, ProductUpdateDto updateDto)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        if(product == null)
        {
            return new ErrorResult(message:"404");
        }
        try
        {
            _mapper.Map(updateDto, product);
            _productRepo.UpdateProduct(product);
            await _productRepo.SaveProductChangesAsync();
            return new SuccessResult(message:"200");
        }
        catch (Exception)
        {
            return new ErrorResult(message:"500");
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteProduct(Guid id)
    {
        var product = await _productRepo.GetProductByIdAsync(id);
        if(product == null)
        {
            return new ErrorResult(message:"404");
        }
        try
        {
            _productRepo.DeleteProduct(product);
            await _productRepo.SaveProductChangesAsync();
            return new SuccessResult(message:"200");
        }
        catch (Exception)
        {
            return new ErrorResult(message:"500");
        }
    }
}
