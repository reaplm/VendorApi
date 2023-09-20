using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vendor.Application.Common.Interface;
using Vendor.Infrastructure.Context;
using Vendor.Infrastructure.Persistence;

namespace Vendor.Infrastructure.Extensions
{
	public static class DependencyInjection
	{
        /// <summary>
        /// Dependency Injection for Infrastructure Layer
        /// </summary>
        /// <param name="services">IServiceCollection</param>
        /// <param name="configuration">IConfiguration</param>
        public static void AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            // Add services to the container.
            string connectionString = configuration.GetSection("ConnectionStrings")["mysqlconnection"];
            services.AddDbContext<VendorContext>(options =>
            options.UseMySQL(connectionString));

            services.AddScoped<IMerchantRepository, MerchantRepository>();

        }
    }
}

