using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Domain.Common;
using TradeAnalytics.Domain.Entities;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Persistence
{
    public class TradeAnalyticsDbContext : DbContext
    {
        public TradeAnalyticsDbContext(DbContextOptions<TradeAnalyticsDbContext> options)
            : base(options)
        {

        }

        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<TradeSecurity> TradeSecurities { get; set; }
        public DbSet<TradeSecurityFee> TradeSecurityFees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TradeAnalyticsDbContext).Assembly);

            //seed data to add through migrations
            var portfolioMastan = Guid.Parse("{939c458e-5e58-4a08-8579-0d9362ebed0f}");

            modelBuilder.Entity<Portfolio>().HasData(new Portfolio
            {
                PortfolioId = portfolioMastan,
                Name = "portfolioMastan",
                Desc = "portfolioMastan is a mastan's portfolio.",
                IsActive = true
            });

            modelBuilder.Entity<TradeSecurity>().HasData(new TradeSecurity
            {
                TradeSecurityId = Guid.Parse("{edcb61fc-b446-48b5-9f43-45a9bc7a4755}"),
                PortfolioId = portfolioMastan,
                Name = "Wipro",
                SecurityCode = "Wipro",
                Desc = "Wipro Limited is an Indian multinational corporation that provides information technology, consulting and business process services.",
                TradeSecurityPerformance = new TradeSecurityPerformance
                {
                    Date = DateTime.Now,
                    OpenPrice = 420.05m,
                    PrevClosed = 422.00m,
                    Volume = 3186358,
                    Value = 1340000000m,
                    Week_52_High = 739.85m,
                    Week_52_Low = 421.75m 

                },
                TradeSecurityFundamentals = new TradeSecurityFundamentals
                {
                    MarketCap = 230618m,
                    PriceToEarning = 18.93m,
                    PriceToBook = 3.51m,
                    PriceToEarning_Industry = 28.31m,
                    DebtToEquity = 0.27m,
                    ReturnOnEquityPerc = 20.18m,
                    EarningPerShare = 22.29m,
                    DividendYield = 1.42m,
                    BookValue = 120.38m,
                    FaceValue = 2
                }
            });
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    //case EntityState.Detached:
                    //    break;
                    //case EntityState.Unchanged:
                    //    break;
                    //case EntityState.Deleted:
                    //    break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
