using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Business.Services.Abstract;
using Business.Services.Concrete;

namespace Business;

public static class ConfigurationServices
{
    public static IServiceCollection AddBusinessConfig(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddAutoMapper(typeof(Program));

        services.AddScoped<IAddressServices, AddressServices>();
        services.AddScoped<IBrandServices, BrandServices>();
        services.AddScoped<ICartItemServices, CartItemServices>();
        services.AddScoped<ICategoryServices, CategoryServices>();
        services.AddScoped<ICommentServices, CommentServices>();
        services.AddScoped<ICouponServices, CouponServices>();
        services.AddScoped<ILanguageServices, LanguageServices>();
        services.AddScoped<IMediaFileServices, MediaFileServices>();
        services.AddScoped<IOrderServices, OrderServices>();
        services.AddScoped<IPaymentDetailServices, PaymentDetailServices>();
        services.AddScoped<IProductServices, ProductServices>();
        services.AddScoped<IShippingDetailServices, ShippingDetailServices>();
        services.AddScoped<IWishlistServices, WishlistServices>();
        
        return services;
    }
}
