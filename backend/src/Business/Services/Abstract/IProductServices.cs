using Core.Utilities.Result.Abstract;
using Entities.DTOs.Product;

namespace Business.Services.Abstract;

public interface IProductServices
{
    public Task<IDataResult<List<ProductResponseDto>>> GetAllProductsAsync();
    public Task<IDataResult<ProductResponseDto>> GetProductByIdAsync(Guid id);
    public Task<Core.Utilities.Result.Abstract.IResult> AddNewProductAsync(ProductCreateDto createDto);
    public Task<Core.Utilities.Result.Abstract.IResult> UpdateProduct(Guid id, ProductUpdateDto updateDto);
    public Task<Core.Utilities.Result.Abstract.IResult> DeleteProduct(Guid id);
}
