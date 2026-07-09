using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.MediaFile;

namespace Business.Profiles;

public class MediaFileMapper : Profile
{
    public MediaFileMapper()
    {
        CreateMap<MediaFileCreateDto, MediaFile>().ReverseMap();
        CreateMap<MediaFile, MediaFileResponseDto>().ReverseMap();
        CreateMap<MediaFileUpdateDto, MediaFile>().ReverseMap();
    }
}
