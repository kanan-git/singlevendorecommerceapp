using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Coupon;

namespace Business.Profiles;

public class CouponMapper : Profile
{
    public CouponMapper()
    {
        CreateMap<CouponCreateDto, Coupon>().ReverseMap();
        CreateMap<Coupon, CouponResponseDto>().ReverseMap();
        CreateMap<CouponUpdateDto, Coupon>().ReverseMap();
    }
}
