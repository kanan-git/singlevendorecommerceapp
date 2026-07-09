using Core.Utilities.Result.Abstract;
using Entities.DTOs.Language;

namespace Business.Services.Abstract;

public interface ILanguageServices
{
    public Task<IDataResult<List<LanguageResponseDto>>> GetAllLanguagesAsync();
    public Task<IDataResult<List<LanguageResponseDto>>> GetAllLanguagesPaginatedAsync(int page, int size);
    public Task<IDataResult<LanguageResponseDto>> GetLanguageByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewLanguageAsync(LanguageCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateLanguage(Guid id, LanguageUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteLanguage(Guid id);
}
