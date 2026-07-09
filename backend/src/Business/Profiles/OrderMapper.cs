using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Order;

namespace Business.Profiles;

public class OrderMapper : Profile
{
    public OrderMapper()
    {
        CreateMap<OrderCreateDto, Order>().ReverseMap();
        CreateMap<Order, OrderResponseDto>().ReverseMap();
        CreateMap<OrderUpdateDto, Order>().ReverseMap();
    }
}
