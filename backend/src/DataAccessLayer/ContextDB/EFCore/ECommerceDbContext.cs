using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Entities.Concrete.Auth;
using Entities.Concrete.Core;

namespace DataAccessLayer.ContextDB.EFCore;

public class ECommerceDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {}

    public DbSet<Brand> Brands {get; set;} = null!;
    public DbSet<Category> Categories {get; set;} = null!;
    public DbSet<Comment> Comments {get; set;} = null!;
    public DbSet<MediaFile> MediaFiles {get; set;} = null!;
    public DbSet<Product> Products {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
