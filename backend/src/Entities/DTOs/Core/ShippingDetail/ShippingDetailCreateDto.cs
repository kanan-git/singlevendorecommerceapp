namespace Entities.DTOs.ShippingDetail;

public class ShippingDetailCreateDto
{
    public Guid ProductId {get; set;}
    public Guid UserId {get; set;}
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
