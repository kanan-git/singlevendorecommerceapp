using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class CategoryRepository : EFCBaseRepository<Category, ECommerceDbContext>, ICategoryRepository
{
    public CategoryRepository(ECommerceDbContext context) : base(context)
    {}
}
