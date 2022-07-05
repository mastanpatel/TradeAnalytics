using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Persistence.Repositories
{
    public class PortfolioRepository : BaseRepository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(TradeAnalyticsDbContext dbContext) : base(dbContext)
        {
        }

    }
}
