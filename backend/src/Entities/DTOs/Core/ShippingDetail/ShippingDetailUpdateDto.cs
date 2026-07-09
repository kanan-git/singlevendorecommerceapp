namespace Entities.DTOs.ShippingDetail;

public class ShippingDetailUpdateDto
{
    public Guid ProductId {get; set;}
    public Guid UserId {get; set;}
    public DateTime UpdatedAt = DateTime.UtcNow;
}
