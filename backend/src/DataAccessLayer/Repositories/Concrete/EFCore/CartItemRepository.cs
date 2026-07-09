using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class CartItemRepository : EFCBaseRepository<CartItem, ECommerceDbContext>, ICartItemRepository
{
    public CartItemRepository(ECommerceDbContext context) : base(context)
    {}
}
