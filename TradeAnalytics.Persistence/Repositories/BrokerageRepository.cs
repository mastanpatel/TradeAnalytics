using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Persistence.Repositories
{
    public class BrokerageRepository : BaseRepository<Brokerage>, IBrokerageRepository
    {
        public BrokerageRepository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }
    }
}