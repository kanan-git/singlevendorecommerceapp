using Entities.Common;

namespace Entities.Concrete.Core;

public class Brand : BaseEntity
{
    #region main
    public string Name {get; set;} = null!;
    #endregion

    #region relational
    public ICollection<Product> Products {get; set;} = new List<Product>(0);
    #endregion
}
