using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Enums;

namespace TradeAnalytics.Domain.Entities.TradeFee
{
    public class Brokerage 
    {
        public Guid BrokerageId { get; set; }
        public Guid TradeSecurityFeeId { get; set; }
        public string BrokerName { get; set; }
        public SecurityType SecurityType { get; set; }
        public SecurityExchangeType ExchangeType { get; set; }
        public Decimal MinimumBrokerageAmt { get; set; }
        public decimal MinimumBrokeragePct { get; set; }
        public decimal BrokerageAmt { get; set; }
    }
}
