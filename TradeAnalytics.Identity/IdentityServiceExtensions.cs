using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TradeAnalytics.Application.Contracts.Identity;
using TradeAnalytics.Identity.Models;
using TradeAnalytics.Identity.Services;

namespace TradeAnalytics.Identity
{
    public static class IdentityServiceExtensions
    {
        public static void AddIdentityServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TradeAnalyticsIdentityDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TradeAnalyticsIdentityCoonectionString"),
                            b => b.MigrationsAssembly(typeof(TradeAnalyticsIdentityDbContext).Assembly.FullName)));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<TradeAnalyticsIdentityDbContext>().AddDefaultTokenProviders();

            services.AddTransient<IAuthenticationService, AuthenticationService>();
        }
    }
}
