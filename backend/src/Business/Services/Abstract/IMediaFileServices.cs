using Core.Utilities.Result.Abstract;
using Entities.DTOs.MediaFile;

namespace Business.Services.Abstract;

public interface IMediaFileServices
{
    public Task<IDataResult<List<MediaFileResponseDto>>> GetAllMediaFilesAsync();
    public Task<IDataResult<List<MediaFileResponseDto>>> GetAllMediaFilesPaginatedAsync(int page, int size);
    public Task<IDataResult<MediaFileResponseDto>> GetMediaFileByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewMediaFileAsync(MediaFileCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateMediaFile(Guid id, MediaFileUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteMediaFile(Guid id);
}
