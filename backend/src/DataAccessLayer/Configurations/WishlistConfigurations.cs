using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class WishlistConfigurations : IEntityTypeConfiguration<Wishlist>
{
    public void Configure(EntityTypeBuilder<Wishlist> builder)
    {
        #region header
        builder.ToTable("Wishlists");
        builder.HasKey(w => w.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(w => w.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
