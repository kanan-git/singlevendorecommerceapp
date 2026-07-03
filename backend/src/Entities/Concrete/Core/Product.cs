using Entities.Common;

namespace Entities.Concrete.Core;

public class Product : BaseEntity
{
    #region main
    public string Title {get; set;} = null!;
    public string? Description {get; set;}
    public int Stock {get; set;} = 0;
    public decimal Price {get; set;}
    public int Discount {get; set;} = 0;
    public decimal DiscountedPrice {get; set;}
    public long RatingReviewCount {get; set;} = 0;
    public long RatingPointSum {get; set;} = 0;
    public double Rating {get; set;} = 0;
    #endregion

    #region relational
    public Guid? BrandId {get; set;}
    public Brand? Brand {get; set;}
    public Guid? CategoryId {get; set;}
    public Category? Category {get; set;}
    public ICollection<MediaFile> ImgPath {get; set;} = new List<MediaFile>(0);
    public ICollection<Comment> Comments {get; set;} = new List<Comment>(0);
    #endregion
}
