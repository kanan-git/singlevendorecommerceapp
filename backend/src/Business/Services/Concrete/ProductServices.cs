using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;
using Entities.Concrete.Core;
using Entities.DTOs.Product;

namespace Business.Services.Concrete;

public class ProductServices : IProductServices
{
    private readonly IMemoryCache _cache;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ProductServices( IMemoryCache cache, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _cache = cache;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<ProductResponseDto>>> GetAllProductsAsync()
    {
        const string cacheKey = "products_all";
        if(!_cache.TryGetValue(cacheKey, out List<ProductResponseDto> data))
        {
            var products = await _unitOfWork.ProductRepository.GetAllAsync(filter:null, "Brand","Category");
            data = _mapper.Map<List<ProductResponseDto>>(products);
            if(data.Count == 0)
            {
                return new ErrorDataResult<List<ProductResponseDto>>(message:ResultMessages.NoMatchFound);
            }
            var options = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10)
            };
            _cache.Set(cacheKey, data, options);
        }
        return new SuccessDataResult<List<ProductResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<ProductResponseDto>>> GetAllProductsPaginatedAsync(int page, int size)
    {
        var products = await _unitOfWork.ProductRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<ProductResponseDto>>(products);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<ProductResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<ProductResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<ProductResponseDto>> GetProductByIdAsync(Guid id)
    {
        var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id==id);
        if(product == null)
        {
            return new ErrorDataResult<ProductResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<ProductResponseDto>(product);
        return new SuccessDataResult<ProductResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewProductAsync(ProductCreateDto createDto)
    {
        var newProduct = _mapper.Map<Product>(createDto);
        if(await _unitOfWork.ProductRepository.IsExistAsync(p => p.Title==newProduct.Title))
        {
            return new ErrorResult(message:ResultMessages.AlreadyExist);
        }
        try{
            await _unitOfWork.ProductRepository.AddAsync(newProduct);
            var result = await _unitOfWork.ProductRepository.SaveAsync();
            if(result > 0)
            {
                _cache.Remove("products_all");
                return new SuccessResult(message:ResultMessages.Created);
            }
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
        catch(Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateProduct(Guid id, ProductUpdateDto updateDto)
    {
        var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id==id);
        if(product == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, product);
            _unitOfWork.ProductRepository.Update(product);
            await _unitOfWork.ProductRepository.SaveAsync();
            _cache.Remove("products_all");
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteProduct(Guid id)
    {
        var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id==id);
        if(product == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.ProductRepository.Remove(product);
            await _unitOfWork.ProductRepository.SaveAsync();
            _cache.Remove("products_all");
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
