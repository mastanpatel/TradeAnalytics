
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Persistence.Repositories;

namespace TradeAnalytics.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TradeAnalyticsDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("TradeAnalyticsCoonectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            services.AddScoped<ITradeSecurityRepository, TradeSecuirtyRepository>();
            // services.AddScoped<ITradeSecurityFeeRespository, TradeSecuirtyFeeRepository>();

            return services;
             
        }
    }
}
