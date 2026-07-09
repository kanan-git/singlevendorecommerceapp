using Entities.Common;
using Entities.Concrete.Auth;

namespace Entities.Concrete.Core;

public class CartItem : BaseEntity
{
    #region main
    public int Quantity {get; set;}
    #endregion

    #region relational
    public Guid UserId {get; set;}
    public AppUser User {get; set;}
    public Guid ProductId {get; set;}
    public Product Product {get; set;}
    #endregion
}
