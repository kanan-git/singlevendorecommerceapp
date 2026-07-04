using Entities.Common;

namespace Entities.Concrete.Core;

public class Country : BaseEntity
{
    public string Language {get; set;} = null!; // Azerbaijani
    public string? LanguageOriginal {get; set;} // Azərbaycanca
    public string CountryName {get; set;} = null!; // Azerbaijan
    public string? CountryNameOriginal {get; set;} // Azərbaycan
    public string CountryIsoCode {get; set;} = null!; // AZ
}
