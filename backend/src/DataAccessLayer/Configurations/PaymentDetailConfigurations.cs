using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class PaymentDetailConfigurations : IEntityTypeConfiguration<PaymentDetail>
{
    public void Configure(EntityTypeBuilder<PaymentDetail> builder)
    {
        #region header
        builder.ToTable("PaymentDetails");
        builder.HasKey(pd => pd.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(pd => pd.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
