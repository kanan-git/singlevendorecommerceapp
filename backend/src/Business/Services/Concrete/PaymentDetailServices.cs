using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.PaymentDetail;

namespace Business.Services.Concrete;

public class PaymentDetailServices : IPaymentDetailServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public PaymentDetailServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<PaymentDetailResponseDto>>> GetAllPaymentDetailsAsync()
    {
        var paymentdetails = await _unitOfWork.PaymentDetailRepository.GetAllAsync();
        var data = _mapper.Map<List<PaymentDetailResponseDto>>(paymentdetails);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<PaymentDetailResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<PaymentDetailResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<PaymentDetailResponseDto>>> GetAllPaymentDetailsPaginatedAsync(int page, int size)
    {
        var paymentdetails = await _unitOfWork.PaymentDetailRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<PaymentDetailResponseDto>>(paymentdetails);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<PaymentDetailResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<PaymentDetailResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<PaymentDetailResponseDto>> GetPaymentDetailByIdAsync(Guid id)
    {
        var paymentdetail = await _unitOfWork.PaymentDetailRepository.GetAsync(pd => pd.Id==id);
        if(paymentdetail == null)
        {
            return new ErrorDataResult<PaymentDetailResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<PaymentDetailResponseDto>(paymentdetail);
        return new SuccessDataResult<PaymentDetailResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewPaymentDetailAsync(PaymentDetailCreateDto createDto)
    {
        var newPaymentDetail = _mapper.Map<PaymentDetail>(createDto);
        if(await _unitOfWork.PaymentDetailRepository.IsExistAsync(pd => pd.TransactionId==newPaymentDetail.TransactionId))
        {
            return new ErrorResult(message:ResultMessages.AlreadyExist);
        }
        try{
            await _unitOfWork.PaymentDetailRepository.AddAsync(newPaymentDetail);
            var result = await _unitOfWork.PaymentDetailRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdatePaymentDetail(Guid id, PaymentDetailUpdateDto updateDto)
    {
        var paymentdetail = await _unitOfWork.PaymentDetailRepository.GetAsync(pd => pd.Id==id);
        if(paymentdetail == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, paymentdetail);
            _unitOfWork.PaymentDetailRepository.Update(paymentdetail);
            await _unitOfWork.PaymentDetailRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeletePaymentDetail(Guid id)
    {
        var paymentdetail = await _unitOfWork.PaymentDetailRepository.GetAsync(pd => pd.Id==id);
        if(paymentdetail == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.PaymentDetailRepository.Remove(paymentdetail);
            await _unitOfWork.PaymentDetailRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
