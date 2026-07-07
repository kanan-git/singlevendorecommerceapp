using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;
using DataAccessLayer.ContextDB.EFCore;

// using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;
using Entities.DTOs.Product;

namespace Business.Services.Concrete;

public class ProductServices : IProductServices
{
    // private readonly IProductRepository _productRepo;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ProductServices(
        // IProductRepository productRepo,
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        // _productRepo = productRepo;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<ProductResponseDto>>> GetAllProductsAsync()
    {
        // var products = await _productRepo.GetAllAsync();
        // var products = await _unitOfWork.ProductRepository.GetAllAsync();
        var products = await _unitOfWork.ProductRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<ProductResponseDto>>(products);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<ProductResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<ProductResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<ProductResponseDto>>> GetAllProductsPaginatedAsync(int page, int size)
    {
        // var products = await _productRepo.GetAllPaginatedAsync(page, size);
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
        // var product = await _productRepo.GetAsync(p => p.Id==id);
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
            // await _productRepo.AddAsync(newProduct);
            await _unitOfWork.ProductRepository.AddAsync(newProduct);
            // await _productRepo.SaveAsync();
            var result = await _unitOfWork.ProductRepository.SaveAsync();
            if(result > 0)
            {
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
        // var product = await _productRepo.GetAsync(p => p.Id==id);
        var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id==id);
        if(product == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, product);
            // _productRepo.Update(product);
            _unitOfWork.ProductRepository.Update(product);
            // await _productRepo.SaveAsync();
            await _unitOfWork.ProductRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteProduct(Guid id)
    {
        // var product = await _productRepo.GetAsync(p => p.Id==id);
        var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id==id);
        if(product == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            // _productRepo.Remove(product);
            _unitOfWork.ProductRepository.Remove(product);
            // await _productRepo.SaveAsync();
            await _unitOfWork.ProductRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
