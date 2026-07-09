using Core.Utilities.Result.Abstract;
using Entities.DTOs.Address;

namespace Business.Services.Abstract;

public interface IAddressServices
{
    public Task<IDataResult<List<AddressResponseDto>>> GetAllAddressesAsync();
    public Task<IDataResult<List<AddressResponseDto>>> GetAllAddressesPaginatedAsync(int page, int size);
    public Task<IDataResult<AddressResponseDto>> GetAddressByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewAddressAsync(AddressCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateAddress(Guid id, AddressUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteAddress(Guid id);
}
