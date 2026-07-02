using Entities.DTOs.Product;

namespace Business.Services.Abstract;

public interface IProductServices
{
    public Task<List<ProductResponseDto>> GetAllProductsAsync();
    public Task<ProductResponseDto> GetProductByIdAsync(Guid id);
    public Task AddNewProductAsync(ProductCreateDto createDto);
    public Task UpdateProduct(Guid id, ProductUpdateDto updateDto);
    public Task<ProductResponseDto> DeleteProduct(Guid id);
}
