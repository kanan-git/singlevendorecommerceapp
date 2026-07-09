namespace Entities.DTOs.Brand;

public class BrandResponseDto
{
    public Guid Id {get; set;}
    public string Name {get; set;} = null!;
    public DateTime CreatedAt {get; set;}
    public DateTime UpdatedAt {get; set;}
}
