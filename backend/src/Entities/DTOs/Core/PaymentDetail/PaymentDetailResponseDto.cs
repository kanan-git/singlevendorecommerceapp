namespace Entities.DTOs.PaymentDetail;

public class PaymentDetailResponseDto
{
    public Guid Id {get; set;}
    public string Provider {get; set;} = string.Empty;
    public string TransactionId {get; set;} = string.Empty;
    public string Status {get; set;} = string.Empty; 
    public decimal Amount {get; set;}
    public Guid OrderId {get; set;}
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
