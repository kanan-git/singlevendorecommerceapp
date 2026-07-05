using DataAccessLayer.Repositories.Abstract;

namespace DataAccessLayer.UnitofWork.Abstract;

public interface IUnitOfWork
{
    public IProductRepository ProductRepository {get;}
    // public IMediaFileRepository MediaFileRepository {get;}
    // public ICommentRepository CommentRepository {get;}
    // public IBrandRepository BrandRepository {get;}
    // public ICategoryRepository CategoryRepository {get;}
    public Task<int> SaveAsync();
}
