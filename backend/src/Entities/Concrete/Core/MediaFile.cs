using Entities.Common;

namespace Entities.Concrete.Core;

public class MediaFile : BaseEntity
{
    #region main
    public string FilePath {get; set;} = null!; // full with extension, product_img_01.jpeg
    public string FileType {get; set;} = null!; // just type, image/png or image/jpg or video/mp4 or what
    public long FileSize {get; set;} // in bytes, 4096 (4096B = 4KB)
    #endregion

    #region relational
    public string EntityType {get; set;} = null!; // which type, Product, AppUser, Brand
    public Guid EntityId {get; set;} // GUID
    #endregion
}
