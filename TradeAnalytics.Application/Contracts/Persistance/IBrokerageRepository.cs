using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Contracts.Persistance
{
    public interface IBrokerageRepository : IAsyncRepository<Brokerage>
    {
    }
}
