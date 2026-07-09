using Entities.Common;

namespace Entities.Concrete.Core;

public class Language : BaseEntity
{
    #region main
    public string Name {get; set;} = null!; // Azerbaijani
    public string? NameOriginal {get; set;} // Azərbaycanca
    public string CountryName {get; set;} = null!; // Azerbaijan
    public string? CountryNameOriginal {get; set;} // Azərbaycan
    public string CountryIsoCode {get; set;} = null!; // AZ
    #endregion

    #region relational
    #endregion
}
