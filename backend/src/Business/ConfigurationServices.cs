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

        services.AddAutoMapper(typeof(Program)); // or services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<IProductServices, ProductServices>();
        
        return services;
    }
}
