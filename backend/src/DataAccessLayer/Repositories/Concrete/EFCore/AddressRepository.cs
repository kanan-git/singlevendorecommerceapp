using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class AddressRepository : EFCBaseRepository<Address, ECommerceDbContext>, IAddressRepository
{
    public AddressRepository(ECommerceDbContext context) : base(context)
    {}
}
