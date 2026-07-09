using Core.Utilities.Result.Abstract;
using Entities.DTOs.Wishlist;

namespace Business.Services.Abstract;

public interface IWishlistServices
{
    public Task<IDataResult<List<WishlistResponseDto>>> GetAllWishlistsAsync();
    public Task<IDataResult<List<WishlistResponseDto>>> GetAllWishlistsPaginatedAsync(int page, int size);
    public Task<IDataResult<WishlistResponseDto>> GetWishlistByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewWishlistAsync(WishlistCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateWishlist(Guid id, WishlistUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteWishlist(Guid id);
}
