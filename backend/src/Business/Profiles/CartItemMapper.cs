using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.CartItem;

namespace Business.Profiles;

public class CartItemMapper : Profile
{
    public CartItemMapper()
    {
        CreateMap<CartItemCreateDto, CartItem>().ReverseMap();
        CreateMap<CartItem, CartItemResponseDto>().ReverseMap();
        CreateMap<CartItemUpdateDto, CartItem>().ReverseMap();
    }
}
