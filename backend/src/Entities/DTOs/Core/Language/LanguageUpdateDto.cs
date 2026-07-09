namespace Entities.DTOs.Language;

public class LanguageUpdateDto
{
    public string Name {get; set;} = null!;
    public string? NameOriginal {get; set;}
    public string CountryName {get; set;} = null!;
    public string? CountryNameOriginal {get; set;}
    public string CountryIsoCode {get; set;} = null!;
    public DateTime UpdatedAt = DateTime.UtcNow;
}
