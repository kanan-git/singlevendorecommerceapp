using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.ShippingDetail;

namespace Business.Services.Concrete;

public class ShippingDetailServices : IShippingDetailServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ShippingDetailServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<ShippingDetailResponseDto>>> GetAllShippingDetailsAsync()
    {
        var shippingdetails = await _unitOfWork.ShippingDetailRepository.GetAllAsync();
        var data = _mapper.Map<List<ShippingDetailResponseDto>>(shippingdetails);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<ShippingDetailResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<ShippingDetailResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<ShippingDetailResponseDto>>> GetAllShippingDetailsPaginatedAsync(int page, int size)
    {
        var shippingdetails = await _unitOfWork.ShippingDetailRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<ShippingDetailResponseDto>>(shippingdetails);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<ShippingDetailResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<ShippingDetailResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<ShippingDetailResponseDto>> GetShippingDetailByIdAsync(Guid id)
    {
        var shippingdetail = await _unitOfWork.ShippingDetailRepository.GetAsync(sd => sd.Id==id);
        if(shippingdetail == null)
        {
            return new ErrorDataResult<ShippingDetailResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<ShippingDetailResponseDto>(shippingdetail);
        return new SuccessDataResult<ShippingDetailResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewShippingDetailAsync(ShippingDetailCreateDto createDto)
    {
        var newShippingDetail = _mapper.Map<ShippingDetail>(createDto);
        try{
            await _unitOfWork.ShippingDetailRepository.AddAsync(newShippingDetail);
            var result = await _unitOfWork.ShippingDetailRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateShippingDetail(Guid id, ShippingDetailUpdateDto updateDto)
    {
        var shippingdetail = await _unitOfWork.ShippingDetailRepository.GetAsync(sd => sd.Id==id);
        if(shippingdetail == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, shippingdetail);
            _unitOfWork.ShippingDetailRepository.Update(shippingdetail);
            await _unitOfWork.ShippingDetailRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteShippingDetail(Guid id)
    {
        var shippingdetail = await _unitOfWork.ShippingDetailRepository.GetAsync(sd => sd.Id==id);
        if(shippingdetail == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.ShippingDetailRepository.Remove(shippingdetail);
            await _unitOfWork.ShippingDetailRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
