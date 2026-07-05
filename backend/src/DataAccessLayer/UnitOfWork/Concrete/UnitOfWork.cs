using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using DataAccessLayer.Repositories.Concrete.EFCore;
using DataAccessLayer.UnitofWork.Abstract;

namespace DataAccessLayer.UnitofWork.Concrete;

public class UnitOfWork : IUnitOfWork
{
    private readonly ECommerceDbContext _dbContext;
    private readonly IProductRepository _productRepo;
    // private readonly IMediaFileRepository _mediaFileRepo;
    // private readonly ICommentRepository _commentRepo;
    // private readonly IBrandRepository _brandRepo;
    // private readonly ICategoryRepository _categoryRepo;
    public UnitOfWork(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IProductRepository ProductRepository => _productRepo ?? new ProductRepository(_dbContext);
    // public IMediaFileRepository MediaFileRepository => _mediaFileRepo ?? new MediaFileRepository(_dbContext);
    // public ICommentRepository CommentRepository => _commentRepo ?? new CommentRepository(_dbContext);
    // public IBrandRepository BrandRepository => _brandRepo ?? new BrandRepository(_dbContext);
    // public ICategoryRepository CategoryRepository => _categoryRepo ?? new CategoryRepository(_dbContext);
    public async Task<int> SaveAsync() => await _dbContext.SaveChangesAsync();
}
