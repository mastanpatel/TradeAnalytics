using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Common;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Domain.Entities
{
    public class TradeSecurity : AuditableEntity
    {
        public Guid TradeSecurityId { get; set; }
        public Guid PortfolioId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
        public TradeSecurityPerformance TradeSecurityPerformance { get; set; }
        public TradeSecurityFundamentals TradeSecurityFundamentals { get; set; }
        public ICollection<TradeSecurityFee> TradeSecurityFees { get; set; }
    }
}
