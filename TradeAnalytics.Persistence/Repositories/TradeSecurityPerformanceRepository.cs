using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Persistence.Repositories
{
    public class TradeSecurityPerformanceRepository : BaseRepository<TradeSecurityPerformance>, ITradeSecurityPerformanceRepository
    {
        public TradeSecurityPerformanceRepository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }
    }
}