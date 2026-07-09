using Core.Utilities.Result.Abstract;
using Entities.DTOs.Order;

namespace Business.Services.Abstract;

public interface IOrderServices
{
    public Task<IDataResult<List<OrderResponseDto>>> GetAllOrdersAsync();
    public Task<IDataResult<List<OrderResponseDto>>> GetAllOrdersPaginatedAsync(int page, int size);
    public Task<IDataResult<OrderResponseDto>> GetOrderByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewOrderAsync(OrderCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateOrder(Guid id, OrderUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteOrder(Guid id);
}
