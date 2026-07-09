using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Coupon;

namespace Business.Services.Concrete;

public class CouponServices : ICouponServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CouponServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<CouponResponseDto>>> GetAllCouponsAsync()
    {
        var coupons = await _unitOfWork.CouponRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<CouponResponseDto>>(coupons);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CouponResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CouponResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<CouponResponseDto>>> GetAllCouponsPaginatedAsync(int page, int size)
    {
        var coupons = await _unitOfWork.CouponRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<CouponResponseDto>>(coupons);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CouponResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CouponResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<CouponResponseDto>> GetCouponByIdAsync(Guid id)
    {
        var coupon = await _unitOfWork.CouponRepository.GetAsync(cpn => cpn.Id==id);
        if(coupon == null)
        {
            return new ErrorDataResult<CouponResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<CouponResponseDto>(coupon);
        return new SuccessDataResult<CouponResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewCouponAsync(CouponCreateDto createDto)
    {
        var newCoupon = _mapper.Map<Coupon>(createDto);
        if(await _unitOfWork.CouponRepository.IsExistAsync(cpn => cpn.Code==newCoupon.Code))
        {
            return new ErrorResult(message:ResultMessages.AlreadyExist);
        }
        try{
            await _unitOfWork.CouponRepository.AddAsync(newCoupon);
            var result = await _unitOfWork.CouponRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateCoupon(Guid id, CouponUpdateDto updateDto)
    {
        var coupon = await _unitOfWork.CouponRepository.GetAsync(cpn => cpn.Id==id);
        if(coupon == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, coupon);
            _unitOfWork.CouponRepository.Update(coupon);
            await _unitOfWork.CouponRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteCoupon(Guid id)
    {
        var coupon = await _unitOfWork.CouponRepository.GetAsync(cpn => cpn.Id==id);
        if(coupon == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.CouponRepository.Remove(coupon);
            await _unitOfWork.CouponRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
