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
            //var portfolioMastan = 1;
            //var wiproTradeSecurity = 1;

            modelBuilder.Entity<Portfolio>().
                HasKey(s => s.PortfolioId);

            modelBuilder.Entity<Portfolio>().
                HasMany(s => s.TradeSecurities).
                WithOne();

            modelBuilder.Entity<TradeSecurity>().
                HasKey(s => s.TradeSecurityId);

            modelBuilder.Entity<TradeSecurity>().
                HasMany(s => s.TradeSecurityFundamentals).
                WithOne();

            modelBuilder.Entity<TradeSecurity>().
                HasMany(s => s.TradeSecurityPerformance).
                WithOne();

            modelBuilder.Entity<TradeSecurity>().
                HasMany(s => s.TradeSecurityFees).
                WithOne();

            modelBuilder.Entity<TradeSecurityFundamentals>().
                HasKey(s => s.TradeSecurityFundamentalsId);

            //modelBuilder.Entity<TradeSecurityFundamentals>()
            //    .HasOne<TradeSecurity>()
            //    .WithMany()
            //    .HasForeignKey(s => s.TradeSecurityId);

            modelBuilder.Entity<TradeSecurityPerformance>().
                HasKey(s => s.TradeSecurityPerformanceId);

            modelBuilder.Entity<TradeSecurityFee>().
                HasKey(s => s.TradeSecurityFeeId);

            //modelBuilder.Entity<TradeSecurityPerformance>()
            //    .HasOne<TradeSecurity>()
            //    .WithMany()
            //    .HasForeignKey(s => s.TradeSecurityId);

            //modelBuilder.Entity<TradeSecurity>().
            //    HasOne(s => s.TradeSecurityFundamentals);

            //modelBuilder.Entity<TradeSecurity>().
            //    HasOne(s => s.TradeSecurityPerformance);

            modelBuilder.Entity<Portfolio>().HasData(new Portfolio
            {
                PortfolioId = 1,
                Name = "portfolioMastan",
                Desc = "portfolioMastan is a mastan's portfolio.",
                IsActive = true,
                TradeSecurities = new HashSet<TradeSecurity>(),
            });

            modelBuilder.Entity<TradeSecurity>().HasData(new TradeSecurity
            {
                TradeSecurityId = 1,
                PortfolioId = 1,
                Name = "Wipro",
                SecurityCode = "Wipro",
                Desc = "Wipro Limited is an Indian multinational corporation that provides information technology, consulting and business process services.",
                TradeSecurityFundamentals = new HashSet<TradeSecurityFundamentals>(),
                TradeSecurityPerformance = new HashSet<TradeSecurityPerformance>(),
                TradeSecurityFees = new HashSet<TradeSecurityFee>(),

                //TradeSecurityFundamentals = new TradeSecurityFundamentals(),
                //TradeSecurityPerformance = new TradeSecurityPerformance()
                //TradeSecurityPerformance = new TradeSecurityPerformance
                //{
                //    TradeSecurityPerformanceId = Guid.Parse("{79bfacfa-59e2-48e1-a494-ed445804221e}"),
                //    TradeSecurityId = wiproTradeSecurity,
                //    Date = DateTime.Now,
                //    OpenPrice = 420.05m,
                //    PrevClosed = 422.00m,
                //    Volume = 3186358,
                //    Value = 1340000000m,
                //    Week_52_High = 739.85m,
                //    Week_52_Low = 421.75m 

                //},
                //TradeSecurityFundamentals = new TradeSecurityFundamentals
                //{
                //    TradeSecurityFundamentalsId = Guid.Parse("{07b764b1-aa58-4375-93cd-e30ce54ace3b}"),
                //    TradeSecurityId = wiproTradeSecurity,
                //    MarketCap = 230618m,
                //    PriceToEarning = 18.93m,
                //    PriceToBook = 3.51m,
                //    PriceToEarning_Industry = 28.31m,
                //    DebtToEquity = 0.27m,
                //    ReturnOnEquityPerc = 20.18m,
                //    EarningPerShare = 22.29m,
                //    DividendYield = 1.42m,
                //    BookValue = 120.38m,
                //    FaceValue = 2
                //}
            }) ;

            modelBuilder.Entity<TradeSecurityFundamentals>().HasData(
                new TradeSecurityFundamentals
                {
                    TradeSecurityFundamentalsId = 1,
                    TradeSecurityId = 1,
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
                });

            modelBuilder.Entity<TradeSecurityPerformance>().HasData(
                new TradeSecurityPerformance
                {
                    TradeSecurityPerformanceId = 1,
                    TradeSecurityId = 1,
                    Date = DateTime.Now,
                    OpenPrice = 420.05m,
                    PrevClosed = 422.00m,
                    Volume = 3186358,
                    Value = 1340000000m,
                    Week_52_High = 739.85m,
                    Week_52_Low = 421.75m

                }
                );
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
