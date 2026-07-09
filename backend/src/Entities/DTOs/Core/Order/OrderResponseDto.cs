namespace Entities.DTOs.Order;

public class OrderResponseDto
{
    public Guid Id {get; set;}
    public int Quantity {get; set;}
    public decimal PriceAtPurchase {get; set;}
    public Guid ProductId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
