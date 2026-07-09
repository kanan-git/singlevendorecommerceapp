using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class MediaFileRepository : EFCBaseRepository<MediaFile, ECommerceDbContext>, IMediaFileRepository
{
    public MediaFileRepository(ECommerceDbContext context) : base(context)
    {}
}
