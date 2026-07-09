using Core.Utilities.Result.Abstract;
using Entities.DTOs.Coupon;

namespace Business.Services.Abstract;

public interface ICouponServices
{
    public Task<IDataResult<List<CouponResponseDto>>> GetAllCouponsAsync();
    public Task<IDataResult<List<CouponResponseDto>>> GetAllCouponsPaginatedAsync(int page, int size);
    public Task<IDataResult<CouponResponseDto>> GetCouponByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewCouponAsync(CouponCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateCoupon(Guid id, CouponUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteCoupon(Guid id);
}
