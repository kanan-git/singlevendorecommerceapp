using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Product;

namespace Business.Mappers;

public class ProductMapper : Profile
{
    public ProductMapper()
    {
        CreateMap<ProductCreateDto, Product>().ReverseMap();
        CreateMap<Product, ProductResponseDto>().ReverseMap();
        CreateMap<ProductUpdateDto, Product>().ReverseMap();
    }
}
