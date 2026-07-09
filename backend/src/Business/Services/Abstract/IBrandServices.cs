using Core.Utilities.Result.Abstract;
using Entities.DTOs.Brand;

namespace Business.Services.Abstract;

public interface IBrandServices
{
    public Task<IDataResult<List<BrandResponseDto>>> GetAllBrandsAsync();
    public Task<IDataResult<List<BrandResponseDto>>> GetAllBrandsPaginatedAsync(int page, int size);
    public Task<IDataResult<BrandResponseDto>> GetBrandByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewBrandAsync(BrandCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateBrand(Guid id, BrandUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteBrand(Guid id);
}
