using AutoMapper;
using Entities.Concrete.Core;
using Entities.DTOs.Comment;

namespace Business.Profiles;

public class CommentMapper : Profile
{
    public CommentMapper()
    {
        CreateMap<CommentCreateDto, Comment>().ReverseMap();
        CreateMap<Comment, CommentResponseDto>().ReverseMap();
        CreateMap<CommentUpdateDto, Comment>().ReverseMap();
    }
}
