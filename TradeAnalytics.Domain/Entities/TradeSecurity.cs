using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Common;

namespace TradeAnalytics.Domain.Entities
{
    internal class TradeSecurity : AuditableEntity
    {
        public Guid TradeSecurityId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
        public TradeSecurityPerformance TradeSecurityPerformance { get; set; }
        public TradeSecurityFundamentals TradeSecurityFundamentals { get; set; }
    }
}
