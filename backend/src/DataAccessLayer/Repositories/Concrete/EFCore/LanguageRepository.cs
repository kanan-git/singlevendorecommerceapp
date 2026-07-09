using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class LanguageRepository : EFCBaseRepository<Language, ECommerceDbContext>, ILanguageRepository
{
    public LanguageRepository(ECommerceDbContext context) : base(context)
    {}
}
