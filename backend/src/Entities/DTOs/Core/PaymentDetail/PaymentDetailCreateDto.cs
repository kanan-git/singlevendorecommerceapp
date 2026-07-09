namespace Entities.DTOs.PaymentDetail;

public class PaymentDetailCreateDto
{
    public string Provider {get; set;} = string.Empty;
    public string TransactionId {get; set;} = string.Empty;
    public string Status {get; set;} = string.Empty; 
    public decimal Amount {get; set;}
    public Guid OrderId {get; set;}
    public DateTime CreatedAt = DateTime.UtcNow;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
