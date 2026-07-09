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

    public DbSet<Address> Addresses {get; set;} = null!;
    public DbSet<Brand> Brands {get; set;} = null!;
    public DbSet<CartItem> CartItems {get; set;} = null!;
    public DbSet<Category> Categories {get; set;} = null!;
    public DbSet<Comment> Comments {get; set;} = null!;
    public DbSet<Coupon> Coupons {get; set;} = null!;
    public DbSet<Language> Languages {get; set;} = null!;
    public DbSet<MediaFile> MediaFiles {get; set;} = null!;
    public DbSet<Order> Orders {get; set;} = null!;
    public DbSet<PaymentDetail> PaymentDetails {get; set;} = null!;
    public DbSet<Product> Products {get; set;} = null!;
    public DbSet<ShippingDetail> ShippingDetails {get; set;} = null!;
    public DbSet<Wishlist> Wishlists {get; set;} = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
