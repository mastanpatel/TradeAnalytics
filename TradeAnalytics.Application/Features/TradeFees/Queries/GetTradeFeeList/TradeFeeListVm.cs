using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeList
{
    public class TradeFeeListVm
    {
        public int TradeSecurityFeeId { get; set; }
        public int TradeSecurityId { get; set; }
        public decimal SecurityTransCharge { get; set; }
        public decimal SecurityExchangeCharge { get; set; }
        public decimal TurnOverFee { get; set; }
        public decimal DPCharge { get; set; }
        public decimal Tax { get; set; }
    }
}