using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class ProductRepository : IProductRepository
{
    private readonly ECommerceDbContext _dbContext;
    public ProductRepository(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ICollection<Product>> GetAllProductsAsync()
    {
        return await _dbContext.Products.ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(Guid id)
    {
        return await _dbContext.Products.FindAsync(id);
    }

    public async Task AddProductAsync(Product product)
    {
        await _dbContext.Products.AddAsync(product);
    }

    public void UpdateProduct(Product product)
    {
        _dbContext.Products.Update(product);
    }

    public void DeleteProduct(Product product)
    {
        _dbContext.Products.Remove(product);
    }

    public async Task<int> SaveProductChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}
