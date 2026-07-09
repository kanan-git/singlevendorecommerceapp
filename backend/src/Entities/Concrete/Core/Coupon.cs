using Entities.Common;

namespace Entities.Concrete.Core;

public class Coupon : BaseEntity
{
    #region main
    public string Code {get; set;} = string.Empty; // e.g., SUMMER50
    public int DiscountValue {get; set;}
    public DateTime ExpiryDate {get; set;}
    public int MaxUsage {get; set;}
    public int CurrentUsage {get; set;}
    public bool IsActive {get; set;}
    #endregion

    #region relational
    #endregion
}
