using AcmeCompany.Crm.Application.Contracts.Persistence;
using AcmeCompany.Crm.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AcmeCompany.Crm.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<CrmDbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("CrmConnectionString")));
            
            // Add repositories
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}