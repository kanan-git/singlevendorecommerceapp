namespace Entities.DTOs.Order;

public class OrderUpdateDto
{
    public int Quantity {get; set;}
    public decimal PriceAtPurchase {get; set;}
    public Guid ProductId {get; set;}
    public DateTime UpdatedAt = DateTime.UtcNow;
}
