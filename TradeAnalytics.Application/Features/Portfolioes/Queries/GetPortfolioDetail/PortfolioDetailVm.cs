using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioDetail
{
    public class PortfolioDetailVm
    {
        public Guid PortfolioId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
        public ICollection<TradeSecurityDto> TradeSecurities { get; set; }
    }
}
