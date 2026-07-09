using Entities.Common;
using Entities.Concrete.Auth;

namespace Entities.Concrete.Core;

public class Wishlist : BaseEntity
{
    #region main
    #endregion

    #region relational
    public Guid ProductId {get; set;}
    public Product Product {get; set;}
    public Guid UserId {get; set;}
    public AppUser User {get; set;}
    #endregion
}
