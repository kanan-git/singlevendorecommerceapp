using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.ShippingDetail;

namespace Business.Profiles;

public class ShippingDetailMapper : Profile
{
    public ShippingDetailMapper()
    {
        CreateMap<ShippingDetailCreateDto, ShippingDetail>().ReverseMap();
        CreateMap<ShippingDetail, ShippingDetailResponseDto>().ReverseMap();
        CreateMap<ShippingDetailUpdateDto, ShippingDetail>().ReverseMap();
    }
}
