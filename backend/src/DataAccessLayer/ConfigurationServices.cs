using Microsoft.EntityFrameworkCore;
using DataAccessLayer.ContextDB.EFCore;
// using DataAccessLayer.Repositories.Abstract;
// using DataAccessLayer.Repositories.Concrete.EFCore;
using DataAccessLayer.UnitofWork.Abstract;
using DataAccessLayer.UnitofWork.Concrete;

namespace DataAccessLayer;

public static class ConfigurationServices
{
    public static IServiceCollection AddDataAccessLayerConfig(this IServiceCollection services, IConfiguration configuration)
    {
        // services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddDbContext<ECommerceDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("Default"))
        );

        return services;
    }
}
