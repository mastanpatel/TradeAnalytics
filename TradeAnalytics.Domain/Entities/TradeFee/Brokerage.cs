using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Domain.Enums;

namespace TradeAnalytics.Domain.Entities.TradeFee
{
    internal class Brokerage : TradeSecurityTransaction
    {
        public Guid BrokerageId { get; set; }
        public string BrokerName { get; set; }
        public SecurityType SecurityType { get; set; }
        public SecurityExchangeType ExchangeType { get; set; }
        public Decimal MinimumBrokerageAmt { get; set; }
        public decimal MinimumBrokeragePct { get; set; }
        public decimal BrokerageAmt { get; set; }
    }
}
