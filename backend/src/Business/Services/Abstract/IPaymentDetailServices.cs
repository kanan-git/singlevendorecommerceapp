using Core.Utilities.Result.Abstract;
using Entities.DTOs.PaymentDetail;

namespace Business.Services.Abstract;

public interface IPaymentDetailServices
{
    public Task<IDataResult<List<PaymentDetailResponseDto>>> GetAllPaymentDetailsAsync();
    public Task<IDataResult<List<PaymentDetailResponseDto>>> GetAllPaymentDetailsPaginatedAsync(int page, int size);
    public Task<IDataResult<PaymentDetailResponseDto>> GetPaymentDetailByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewPaymentDetailAsync(PaymentDetailCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdatePaymentDetail(Guid id, PaymentDetailUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeletePaymentDetail(Guid id);
}
