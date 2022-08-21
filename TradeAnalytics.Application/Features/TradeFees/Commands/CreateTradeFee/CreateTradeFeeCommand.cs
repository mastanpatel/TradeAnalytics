using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.CreateTradeFee
{
    public class CreateTradeFeeCommand : IRequest<int>
    {
        public int TradeSecurityId { get; set; }
        //public BrokerageDto Brokerage { get; set; }
        public decimal SecurityTransCharge { get; set; }
        public decimal SecurityExchangeCharge { get; set; }
        public decimal TurnOverFee { get; set; }
        //public StampDutyDto StampDuty { get; set; }
        public decimal DPCharge { get; set; }
        public decimal Tax { get; set; }
    }
}
