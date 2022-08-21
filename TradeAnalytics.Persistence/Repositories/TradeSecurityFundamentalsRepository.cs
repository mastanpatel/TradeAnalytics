using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Persistence.Repositories
{
    public class TradeSecurityFundamentalsRepository : BaseRepository<TradeSecurityFundamentals>, ITradeSecurityFundamentalsRepository
    {
        public TradeSecurityFundamentalsRepository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }
    }
}