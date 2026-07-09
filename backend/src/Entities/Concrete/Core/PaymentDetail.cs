using Entities.Common;

namespace Entities.Concrete.Core;

public class PaymentDetail : BaseEntity
{
    #region main
    public string Provider {get; set;} = string.Empty; // e.g., Stripe, PayPal
    public string TransactionId {get; set;} = string.Empty;
    public string Status {get; set;} = string.Empty;   // Pending, Succeeded, Failed
    public decimal Amount {get; set;}
    #endregion

    #region relational
    public Guid OrderId {get; set;}
    public Order Order {get; set;}
    #endregion
}
