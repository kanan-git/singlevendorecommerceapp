using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class BrandRepository : EFCBaseRepository<Brand, ECommerceDbContext>, IBrandRepository
{
    public BrandRepository(ECommerceDbContext context) : base(context)
    {}
}
