using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Wishlist;

namespace Business.Profiles;

public class WishlistMapper : Profile
{
    public WishlistMapper()
    {
        CreateMap<WishlistCreateDto, Wishlist>().ReverseMap();
        CreateMap<Wishlist, WishlistResponseDto>().ReverseMap();
        CreateMap<WishlistUpdateDto, Wishlist>().ReverseMap();
    }
}
