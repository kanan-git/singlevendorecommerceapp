using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class CouponRepository : EFCBaseRepository<Coupon, ECommerceDbContext>, ICouponRepository
{
    public CouponRepository(ECommerceDbContext context) : base(context)
    {}
}
