using Microsoft.EntityFrameworkCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.Repositories.Abstract;
using DataAccessLayer.Repositories.Concrete.EFCore;

namespace DataAccessLayer;

public static class ConfigurationServices
{
    public static IServiceCollection AddDataAccessLayerConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddDbContext<ECommerceDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("Default"))
        );

        return services;
    }
}
