using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class PaymentDetailRepository : EFCBaseRepository<PaymentDetail, ECommerceDbContext>, IPaymentDetailRepository
{
    public PaymentDetailRepository(ECommerceDbContext context) : base(context)
    {}
}
