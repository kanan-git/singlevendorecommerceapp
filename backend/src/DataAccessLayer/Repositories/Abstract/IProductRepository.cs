using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Abstract;

public interface IProductRepository
{
    Task <ICollection<Product>> GetAllProductsAsync();
    Task <Product> GetProductByIdAsync(Guid id);
    Task AddProductAsync(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(Product product);
    Task SaveProductChangesAsync();
}
