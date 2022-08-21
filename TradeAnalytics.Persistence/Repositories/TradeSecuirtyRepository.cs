using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Persistence.Repositories
{
    public class TradeSecuirtyRepository : BaseRepository<TradeSecurity>, ITradeSecurityRepository
    {
        public TradeSecuirtyRepository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
