using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Common;

namespace TradeAnalytics.Domain.Entities
{
    internal class Portfolio : AuditableEntity
    {
        public Guid PortfolioId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
        public ICollection<TradeSecurity> TradeSecurities { get; set; }
    }
}
