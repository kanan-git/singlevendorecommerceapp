using Entities.Common;

namespace Entities.Concrete.Core;

public class Order : BaseEntity
{
    #region main
    public int Quantity {get; set;}
    public decimal PriceAtPurchase {get; set;} // Prevents history distortion if product price changes
    #endregion

    #region relational
    public Guid ProductId {get; set;}
    public Product Product {get; set;}
    #endregion
}
