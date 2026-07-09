using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Brand;

namespace Business.Services.Concrete;

public class BrandServices : IBrandServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public BrandServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<BrandResponseDto>>> GetAllBrandsAsync()
    {
        var brands = await _unitOfWork.BrandRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<BrandResponseDto>>(brands);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<BrandResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<BrandResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<BrandResponseDto>>> GetAllBrandsPaginatedAsync(int page, int size)
    {
        var brands = await _unitOfWork.BrandRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<BrandResponseDto>>(brands);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<BrandResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<BrandResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<BrandResponseDto>> GetBrandByIdAsync(Guid id)
    {
        var brand = await _unitOfWork.BrandRepository.GetAsync(b => b.Id==id);
        if(brand == null)
        {
            return new ErrorDataResult<BrandResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<BrandResponseDto>(brand);
        return new SuccessDataResult<BrandResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewBrandAsync(BrandCreateDto createDto)
    {
        var newBrand = _mapper.Map<Brand>(createDto);
        if(await _unitOfWork.BrandRepository.IsExistAsync(b => b.Name==newBrand.Name))
        {
            return new ErrorResult(message:ResultMessages.AlreadyExist);
        }
        try{
            await _unitOfWork.BrandRepository.AddAsync(newBrand);
            var result = await _unitOfWork.BrandRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateBrand(Guid id, BrandUpdateDto updateDto)
    {
        var brand = await _unitOfWork.BrandRepository.GetAsync(b => b.Id==id);
        if(brand == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, brand);
            _unitOfWork.BrandRepository.Update(brand);
            await _unitOfWork.BrandRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteBrand(Guid id)
    {
        var brand = await _unitOfWork.BrandRepository.GetAsync(b => b.Id==id);
        if(brand == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.BrandRepository.Remove(brand);
            await _unitOfWork.BrandRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
