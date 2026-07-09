using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Language;

namespace Business.Profiles;

public class LanguageMapper : Profile
{
    public LanguageMapper()
    {
        CreateMap<LanguageCreateDto, Language>().ReverseMap();
        CreateMap<Language, LanguageResponseDto>().ReverseMap();
        CreateMap<LanguageUpdateDto, Language>().ReverseMap();
    }
}
