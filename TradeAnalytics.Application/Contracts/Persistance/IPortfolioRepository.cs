using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Contracts.Persistance
{
    public interface IPortfolioRepository : IAsyncRepository<Portfolio>
    {

    }
}
