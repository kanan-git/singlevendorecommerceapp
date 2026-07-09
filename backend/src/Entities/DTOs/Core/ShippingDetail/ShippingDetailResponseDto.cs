namespace Entities.DTOs.ShippingDetail;

public class ShippingDetailResponseDto
{
    public Guid Id {get; set;}
    public Guid ProductId {get; set;}
    public Guid UserId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
