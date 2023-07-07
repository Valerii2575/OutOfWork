using Microsoft.EntityFrameworkCore;
using OutOfWork.Core.Interfaces;
using OutOfWork.Infrastructure;
using OutOfWork.Infrastructure.Repositories;

namespace OutOfWork.API.Extentions
{
    public static class AddServiceExtentions
    {
        public static IServiceCollection UseDependenciesService(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }

        public static IServiceCollection UseConfigurationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DbContextClass>(options => {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
        }
    }
}