using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class ShippingDetailConfigurations : IEntityTypeConfiguration<ShippingDetail>
{
    public void Configure(EntityTypeBuilder<ShippingDetail> builder)
    {
        #region header
        builder.ToTable("ShippingDetails");
        builder.HasKey(sd => sd.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(sd => sd.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
