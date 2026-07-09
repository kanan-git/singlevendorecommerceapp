using Core.Utilities.Result.Abstract;
using Entities.DTOs.ShippingDetail;

namespace Business.Services.Abstract;

public interface IShippingDetailServices
{
    public Task<IDataResult<List<ShippingDetailResponseDto>>> GetAllShippingDetailsAsync();
    public Task<IDataResult<List<ShippingDetailResponseDto>>> GetAllShippingDetailsPaginatedAsync(int page, int size);
    public Task<IDataResult<ShippingDetailResponseDto>> GetShippingDetailByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewShippingDetailAsync(ShippingDetailCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateShippingDetail(Guid id, ShippingDetailUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteShippingDetail(Guid id);
}
