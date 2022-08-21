using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Persistence.Repositories
{
    public class TradeSecurityTransactionRepository : BaseRepository<TradeSecurityTransaction>, ITradeSecurityTransactionRepository
    {
        public TradeSecurityTransactionRepository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }
    }
}