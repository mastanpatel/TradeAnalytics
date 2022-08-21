using TradeAnalytics.Domain.Enums;

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail
{
    public class BrokerageDto
    {
        public int BrokerageId { get; set; }
        public int TradeSecurityFeeId { get; set; }
        public string BrokerName { get; set; }
        public SecurityType SecurityType { get; set; }
        public SecurityExchangeType ExchangeType { get; set; }
        public decimal MinimumBrokerageAmt { get; set; }
        public decimal MinimumBrokeragePct { get; set; }
        public decimal BrokerageAmt { get; set; }
    }
}