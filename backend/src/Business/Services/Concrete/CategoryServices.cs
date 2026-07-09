using AutoMapper;
using Business.Services.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccessLayer.UnitofWork.Abstract;

using Entities.Concrete.Core;
using Entities.DTOs.Category;

namespace Business.Services.Concrete;

public class CategoryServices : ICategoryServices
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CategoryServices(
        IUnitOfWork unitOfWork,
        IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IDataResult<List<CategoryResponseDto>>> GetAllCategoriesAsync()
    {
        var categories = await _unitOfWork.CategoryRepository.GetAllAsync(filter:null, "Brand","Category");
        var data = _mapper.Map<List<CategoryResponseDto>>(categories);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CategoryResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CategoryResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<List<CategoryResponseDto>>> GetAllCategoriesPaginatedAsync(int page, int size)
    {
        var categories = await _unitOfWork.CategoryRepository.GetAllPaginatedAsync(page, size);
        var data = _mapper.Map<List<CategoryResponseDto>>(categories);
        if(data.Count == 0)
        {
            return new ErrorDataResult<List<CategoryResponseDto>>(message:ResultMessages.NoMatchFound);
        }
        return new SuccessDataResult<List<CategoryResponseDto>>(data:data, message:ResultMessages.Readed);
    }

    public async Task<IDataResult<CategoryResponseDto>> GetCategoryByIdAsync(Guid id)
    {
        var category = await _unitOfWork.CategoryRepository.GetAsync(ctg => ctg.Id==id);
        if(category == null)
        {
            return new ErrorDataResult<CategoryResponseDto>(message:ResultMessages.NoMatchFound);
        }
        var data = _mapper.Map<CategoryResponseDto>(category);
        return new SuccessDataResult<CategoryResponseDto>(data:data, message:ResultMessages.Readed);
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> AddNewCategoryAsync(CategoryCreateDto createDto)
    {
        var newCategory = _mapper.Map<Category>(createDto);
        if(await _unitOfWork.CategoryRepository.IsExistAsync(ctg => ctg.Name==newCategory.Name))
        {
            return new ErrorResult(message:ResultMessages.AlreadyExist);
        }
        try{
            await _unitOfWork.CategoryRepository.AddAsync(newCategory);
            var result = await _unitOfWork.CategoryRepository.SaveAsync();
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

    public async Task<Core.Utilities.Result.Abstract.IResult> UpdateCategory(Guid id, CategoryUpdateDto updateDto)
    {
        var category = await _unitOfWork.CategoryRepository.GetAsync(ctg => ctg.Id==id);
        if(category == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _mapper.Map(updateDto, category);
            _unitOfWork.CategoryRepository.Update(category);
            await _unitOfWork.CategoryRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Updated);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }

    public async Task<Core.Utilities.Result.Abstract.IResult> DeleteCategory(Guid id)
    {
        var category = await _unitOfWork.CategoryRepository.GetAsync(ctg => ctg.Id==id);
        if(category == null)
        {
            return new ErrorResult(message:ResultMessages.NoMatchFound);
        }
        try
        {
            _unitOfWork.CategoryRepository.Remove(category);
            await _unitOfWork.CategoryRepository.SaveAsync();
            return new SuccessResult(message:ResultMessages.Deleted);
        }
        catch (Exception)
        {
            return new ErrorResult(message:ResultMessages.UnknownFail);
        }
    }
}
