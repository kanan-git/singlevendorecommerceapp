using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class ShippingDetailRepository : EFCBaseRepository<ShippingDetail, ECommerceDbContext>, IShippingDetailRepository
{
    public ShippingDetailRepository(ECommerceDbContext context) : base(context)
    {}
}
