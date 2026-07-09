using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Concrete.Core;

namespace DataAccessLayer.Configurations;

public class AddressConfigurations : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        #region header
        builder.ToTable("Addresses");
        builder.HasKey(a => a.Id);
        builder.Property<Guid>("Id");
        #endregion

        #region main
        // builder.Property(a => a.)
        #endregion
        
        #region relational
        // builder.Has
        #endregion
    }
}
