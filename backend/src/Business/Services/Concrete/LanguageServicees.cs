using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Language;

namespace Business.Services.Concrete;

public class LanguageServices : ILanguageServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public LanguageServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<LanguageResponseDto>>> GetAllLanguagesAsync()
    {
        var languages = await _unitOfWork.LanguageRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<LanguageResponseDto>>(languages);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<LanguageResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<LanguageResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<LanguageResponseDto>>> GetAllLanguagesPaginatedAsync(int page, int size)
    {
        var languages = await _unitOfWork.LanguageRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<LanguageResponseDto>>(languages);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<LanguageResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<LanguageResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<LanguageResponseDto>> GetLanguageByIdAsync(Guid id)
    {
        var language = await _unitOfWork.LanguageRepository.GetAsync(l => l.Id==id);
        if(language == null)
        {
            return new ErrorDataResult<LanguageResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<LanguageResponseDto>(language);
        return new SuccessDataResult<LanguageResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewLanguageAsync(LanguageCreateDto createDto)
    {
        var newLanguage = _mapper.Map<Language>(createDto);
        if(await _unitOfWork.LanguageRepository.IsExistAsync(l => l.CountryIsoCode==newLanguage.CountryIsoCode))
        {
            return new ErrorResult(message:ResultMessages.AlreadyExist);
        }
        try{
            await _unitOfWork.LanguageRepository.AddAsync(newLanguage);
            var result = await _unitOfWork.LanguageRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateLanguage(Guid id, LanguageUpdateDto updateDto)
    {
        var language = await _unitOfWork.LanguageRepository.GetAsync(l => l.Id==id);
        if(language == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, language);
            _unitOfWork.LanguageRepository.Update(language);
            await _unitOfWork.LanguageRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteLanguage(Guid id)
    {
        var language = await _unitOfWork.LanguageRepository.GetAsync(l => l.Id==id);
        if(language == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.LanguageRepository.Remove(language);
            await _unitOfWork.LanguageRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
