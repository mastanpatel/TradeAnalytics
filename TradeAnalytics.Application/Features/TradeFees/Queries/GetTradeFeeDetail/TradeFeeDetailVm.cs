using System.Collections.Generic;
using TradeAnalytics.Application.Features.TradeFees.Commands.CreateTradeFee;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail
{
    public class TradeFeeDetailVm
    {
        public TradeFeeDetailVm()
        {
            this.Brokerage = new BrokerageDto();
            this.StampDuty = new StampDutyDto();
        }
        public int TradeSecurityFeeId { get; set; }
        public int TradeSecurityId { get; set; }
        public BrokerageDto Brokerage { get; set; }
        public decimal SecurityTransCharge { get; set; }
        public decimal SecurityExchangeCharge { get; set; }
        public decimal TurnOverFee { get; set; }
        public StampDutyDto StampDuty { get; set; }
        public decimal DPCharge { get; set; }
        public decimal Tax { get; set; }
    }
}