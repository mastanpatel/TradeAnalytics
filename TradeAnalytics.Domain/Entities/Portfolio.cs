using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Common;

namespace TradeAnalytics.Domain.Entities
{
    public class Portfolio : AuditableEntity
    {
        public Portfolio()
        {
            this.TradeSecurities = new HashSet<TradeSecurity>();
        }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
        public ICollection<TradeSecurity> TradeSecurities { get; set; }
    }
}
