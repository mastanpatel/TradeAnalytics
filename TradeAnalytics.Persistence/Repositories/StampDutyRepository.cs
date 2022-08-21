using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Persistence.Repositories
{
    public class StampDutyRepository : BaseRepository<StampDuty>, IStampDutyRepository
    {
        public StampDutyRepository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }
    }
}