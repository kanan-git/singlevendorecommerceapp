namespace Entities.DTOs.Address;

public class AddressUpdateDto
{
    public string AddressLine {get; set;} = string.Empty;
    public string City {get; set;} = string.Empty;
    public string State {get; set;} = string.Empty;
    public string PostalCode {get; set;} = string.Empty;
    public string Country {get; set;} = string.Empty;
    public bool IsDefaultShipping {get; set;}
    public bool IsDefaultBilling {get; set;}
    public DateTime UpdatedAt = DateTime.UtcNow;
}
