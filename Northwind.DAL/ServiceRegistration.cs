using Microsoft.Extensions.DependencyInjection;
using Northwind.DAL.Repository;

namespace Northwind.DAL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            return services;
        }
    }
}
