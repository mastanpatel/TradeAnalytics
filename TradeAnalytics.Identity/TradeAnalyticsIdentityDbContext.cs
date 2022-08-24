using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Identity.Models;

namespace TradeAnalytics.Identity
{
    public class TradeAnalyticsIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public TradeAnalyticsIdentityDbContext(DbContextOptions<TradeAnalyticsIdentityDbContext> options) : base(options)
        {

        }
    }
}
