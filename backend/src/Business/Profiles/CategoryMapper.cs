using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Category;

namespace Business.Profiles;

public class CategoryMapper : Profile
{
    public CategoryMapper()
    {
        CreateMap<CategoryCreateDto, Category>().ReverseMap();
        CreateMap<Category, CategoryResponseDto>().ReverseMap();
        CreateMap<CategoryUpdateDto, Category>().ReverseMap();
    }
}
