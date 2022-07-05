using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Persistence.Repositories
{
    public class TradeSecurityFeeRespository : BaseRepository<TradeSecurityFee>, ITradeSecurityFeeRespository
    {
        public TradeSecurityFeeRespository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }
    }
}
