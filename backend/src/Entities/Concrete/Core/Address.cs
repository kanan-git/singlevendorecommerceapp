using Entities.Common;

namespace Entities.Concrete.Core;

public class Address : BaseEntity
{
    #region main
    public string AddressLine {get; set;} = string.Empty;
    public string City {get; set;} = string.Empty;
    public string State {get; set;} = string.Empty;
    public string PostalCode {get; set;} = string.Empty;
    public string Country {get; set;} = string.Empty;
    public bool IsDefaultShipping {get; set;}
    public bool IsDefaultBilling {get; set;}
    #endregion

    #region relational
    #endregion
}
