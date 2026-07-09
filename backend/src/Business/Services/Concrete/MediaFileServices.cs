using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.MediaFile;

namespace Business.Services.Concrete;

public class MediaFileServices : IMediaFileServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public MediaFileServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<MediaFileResponseDto>>> GetAllMediaFilesAsync()
    {
        var mediafiles = await _unitOfWork.MediaFileRepository.GetAllAsync();
        var data = _mapper.Map<List<MediaFileResponseDto>>(mediafiles);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<MediaFileResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<MediaFileResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<MediaFileResponseDto>>> GetAllMediaFilesPaginatedAsync(int page, int size)
    {
        var mediafiles = await _unitOfWork.MediaFileRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<MediaFileResponseDto>>(mediafiles);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<MediaFileResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<MediaFileResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<MediaFileResponseDto>> GetMediaFileByIdAsync(Guid id)
    {
        var mediafile = await _unitOfWork.MediaFileRepository.GetAsync(mf => mf.Id==id);
        if(mediafile == null)
        {
            return new ErrorDataResult<MediaFileResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<MediaFileResponseDto>(mediafile);
        return new SuccessDataResult<MediaFileResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewMediaFileAsync(MediaFileCreateDto createDto)
    {
        var newMediaFile = _mapper.Map<MediaFile>(createDto);
        if(await _unitOfWork.MediaFileRepository.IsExistAsync(mf => mf.FilePath==newMediaFile.FilePath))
        {
            return new ErrorResult(message:ResultMessages.AlreadyExist);
        }
        try{
            await _unitOfWork.MediaFileRepository.AddAsync(newMediaFile);
            var result = await _unitOfWork.MediaFileRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateMediaFile(Guid id, MediaFileUpdateDto updateDto)
    {
        var mediafile = await _unitOfWork.MediaFileRepository.GetAsync(mf => mf.Id==id);
        if(mediafile == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, mediafile);
            _unitOfWork.MediaFileRepository.Update(mediafile);
            await _unitOfWork.MediaFileRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteMediaFile(Guid id)
    {
        var mediafile = await _unitOfWork.MediaFileRepository.GetAsync(mf => mf.Id==id);
        if(mediafile == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.MediaFileRepository.Remove(mediafile);
            await _unitOfWork.MediaFileRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
