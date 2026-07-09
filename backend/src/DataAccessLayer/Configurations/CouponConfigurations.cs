using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class CouponConfigurations : IEntityTypeConfiguration<Coupon>
{
    public void Configure(EntityTypeBuilder<Coupon> builder)
    {
        #region header
        builder.ToTable("Coupons");
        builder.HasKey(cpn => cpn.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(cpn => cpn.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
