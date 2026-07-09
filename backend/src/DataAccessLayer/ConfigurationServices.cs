using Microsoft.EntityFrameworkCore;
using DataAccessLayer.ContextDB.EFCore;
using DataAccessLayer.UnitofWork.Abstract;
using DataAccessLayer.UnitofWork.Concrete;

namespace DataAccessLayer;

public static class ConfigurationServices
{
    public static IServiceCollection AddDataAccessLayerConfig(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddDbContext<ECommerceDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("Default"))
        );

        return services;
    }
}
