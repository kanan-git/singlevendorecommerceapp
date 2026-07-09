using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class OrderRepository : EFCBaseRepository<Order, ECommerceDbContext>, IOrderRepository
{
    public OrderRepository(ECommerceDbContext context) : base(context)
    {}
}
