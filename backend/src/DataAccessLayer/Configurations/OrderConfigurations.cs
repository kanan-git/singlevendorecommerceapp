using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class OrderConfigurations : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        #region header
        builder.ToTable("Orders");
        builder.HasKey(o => o.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(o => o.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
