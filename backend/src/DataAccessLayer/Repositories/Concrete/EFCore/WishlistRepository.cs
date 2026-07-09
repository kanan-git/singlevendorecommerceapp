using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class WishlistRepository : EFCBaseRepository<Wishlist, ECommerceDbContext>, IWishlistRepository
{
    public WishlistRepository(ECommerceDbContext context) : base(context)
    {}
}
