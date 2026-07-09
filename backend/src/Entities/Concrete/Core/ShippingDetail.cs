using Entities.Common;

namespace Entities.Concrete.Core;

public class ShippingDetail : BaseEntity
{
    #region main
    public string Carrier {get; set;} = string.Empty;     // e.g., FedEx, DHL
    public string TrackingNumber {get; set;} = string.Empty;
    public string Status {get; set;} = string.Empty;      // Shipped, InTransit, Delivered
    public DateTime? EstimatedDelivery {get; set;}
    #endregion

    #region relational
    public Guid OrderId {get; set;}
    public Order Order {get; set;}
    #endregion
}
