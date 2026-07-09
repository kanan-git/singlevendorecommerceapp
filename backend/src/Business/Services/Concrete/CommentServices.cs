using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Comment;

namespace Business.Services.Concrete;

public class CommentServices : ICommentServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CommentServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<CommentResponseDto>>> GetAllCommentsAsync()
    {
        var comments = await _unitOfWork.CommentRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<CommentResponseDto>>(comments);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CommentResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CommentResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<CommentResponseDto>>> GetAllCommentsPaginatedAsync(int page, int size)
    {
        var comments = await _unitOfWork.CommentRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<CommentResponseDto>>(comments);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CommentResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CommentResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<CommentResponseDto>> GetCommentByIdAsync(Guid id)
    {
        var comment = await _unitOfWork.CommentRepository.GetAsync(com => com.Id==id);
        if(comment == null)
        {
            return new ErrorDataResult<CommentResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<CommentResponseDto>(comment);
        return new SuccessDataResult<CommentResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewCommentAsync(CommentCreateDto createDto)
    {
        var newComment = _mapper.Map<Comment>(createDto);
        try{
            await _unitOfWork.CommentRepository.AddAsync(newComment);
            var result = await _unitOfWork.CommentRepository.SaveAsync();
            if(result > 0)
            {
                return new SuccessResult(message:ResultMessages.Created);
            }
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
        catch(Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateComment(Guid id, CommentUpdateDto updateDto)
    {
        var comment = await _unitOfWork.CommentRepository.GetAsync(com => com.Id==id);
        if(comment == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, comment);
            _unitOfWork.CommentRepository.Update(comment);
            await _unitOfWork.CommentRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteComment(Guid id)
    {
        var comment = await _unitOfWork.CommentRepository.GetAsync(com => com.Id==id);
        if(comment == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.CommentRepository.Remove(comment);
            await _unitOfWork.CommentRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
