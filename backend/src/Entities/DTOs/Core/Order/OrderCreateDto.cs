namespace Entities.DTOs.Order;

public class OrderCreateDto
{
    public int Quantity {get; set;}
    public decimal PriceAtPurchase {get; set;}
    public Guid ProductId {get; set;}
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
