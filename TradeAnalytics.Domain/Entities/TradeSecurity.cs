using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Common;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Domain.Entities
{
    public class TradeSecurity : AuditableEntity
    {
        public TradeSecurity()
        {
            this.TradeSecurityPerformance = new HashSet<TradeSecurityPerformance>();
            this.TradeSecurityFundamentals = new HashSet<TradeSecurityFundamentals>();
            this.TradeSecurityFees = new HashSet<TradeSecurityFee>();
        }
        public int TradeSecurityId { get; set; }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
        public ICollection<TradeSecurityPerformance> TradeSecurityPerformance { get; set; }
        public ICollection<TradeSecurityFundamentals> TradeSecurityFundamentals { get; set; }
        public ICollection<TradeSecurityFee> TradeSecurityFees { get; set; }
    }
}
