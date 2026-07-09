using Core.Utilities.Result.Abstract;
using Entities.DTOs.Comment;

namespace Business.Services.Abstract;

public interface ICommentServices
{
    public Task<IDataResult<List<CommentResponseDto>>> GetAllCommentsAsync();
    public Task<IDataResult<List<CommentResponseDto>>> GetAllCommentsPaginatedAsync(int page, int size);
    public Task<IDataResult<CommentResponseDto>> GetCommentByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewCommentAsync(CommentCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateComment(Guid id, CommentUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteComment(Guid id);
}
