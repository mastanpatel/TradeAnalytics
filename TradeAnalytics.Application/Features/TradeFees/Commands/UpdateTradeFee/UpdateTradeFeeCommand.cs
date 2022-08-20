using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.UpdateTradeFee
{
    public class UpdateTradeFeeCommand : IRequest
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
