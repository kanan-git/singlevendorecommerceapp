using Core.Utilities.Result.Abstract;
using Entities.DTOs.Category;

namespace Business.Services.Abstract;

public interface ICategoryServices
{
    public Task<IDataResult<List<CategoryResponseDto>>> GetAllCategoriesAsync();
    public Task<IDataResult<List<CategoryResponseDto>>> GetAllCategoriesPaginatedAsync(int page, int size);
    public Task<IDataResult<CategoryResponseDto>> GetCategoryByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewCategoryAsync(CategoryCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateCategory(Guid id, CategoryUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteCategory(Guid id);
}
