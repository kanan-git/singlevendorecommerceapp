using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class CartItemConfigurations : IEntityTypeConfiguration<CartItem>
{
    public void Configure(EntityTypeBuilder<CartItem> builder)
    {
        #region header
        builder.ToTable("CartItems");
        builder.HasKey(ci => ci.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(ci => ci.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
