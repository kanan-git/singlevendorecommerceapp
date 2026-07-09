using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Brand;

namespace Business.Profiles;

public class BrandMapper : Profile
{
    public BrandMapper()
    {
        CreateMap<BrandCreateDto, Brand>().ReverseMap();
        CreateMap<Brand, BrandResponseDto>().ReverseMap();
        CreateMap<BrandUpdateDto, Brand>().ReverseMap();
    }
}
