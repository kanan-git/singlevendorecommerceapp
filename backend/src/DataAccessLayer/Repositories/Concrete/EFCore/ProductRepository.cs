using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class ProductRepository : EFCBaseRepository<Product, ECommerceDbContext>, IProductRepository
{
    public ProductRepository(ECommerceDbContext context) : base(context)
    {}
}
