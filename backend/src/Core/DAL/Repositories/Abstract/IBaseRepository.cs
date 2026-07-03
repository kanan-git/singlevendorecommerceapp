using System.Linq.Expressions;

namespace Core.DAL.Repositories.Abstract;

public interface IBaseRepository<TEntity>
    where TEntity : class, new()
{
    public Task<ICollection<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, params string[] includes);
    public Task<ICollection<TEntity>> GetAllPaginatedAsync(int page, int size, Expression<Func<TEntity, bool>> filter = null, params string[] includes);
    public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, params string[] includes);
    public Task AddAsync(TEntity entity);
    public void Update(TEntity entity);
    public void Remove(TEntity entity);
    public IQueryable<TEntity> GetQuery(string[] includes);
    public Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> filter);
    public Task<int> SaveAsync();
}
