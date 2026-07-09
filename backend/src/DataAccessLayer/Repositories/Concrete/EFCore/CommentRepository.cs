using Core.DAL.Repositories.Concrete.EFCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using Entities.Concrete.Core;

namespace DataAccessLayer.Repositories.Concrete.EFCore;

public class CommentRepository : EFCBaseRepository<Comment, ECommerceDbContext>, ICommentRepository
{
    public CommentRepository(ECommerceDbContext context) : base(context)
    {}
}
