using Core.Utilities.Result.Abstract;
using Entities.DTOs.CartItem;

namespace Business.Services.Abstract;

public interface ICartItemServices
{
    public Task<IDataResult<List<CartItemResponseDto>>> GetAllCartItemsAsync();
    public Task<IDataResult<List<CartItemResponseDto>>> GetAllCartItemsPaginatedAsync(int page, int size);
    public Task<IDataResult<CartItemResponseDto>> GetCartItemByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewCartItemAsync(CartItemCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateCartItem(Guid id, CartItemUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteCartItem(Guid id);
}
