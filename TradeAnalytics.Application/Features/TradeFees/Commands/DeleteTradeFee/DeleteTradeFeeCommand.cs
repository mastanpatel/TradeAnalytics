using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.DeleteTradeFee
{
    public class DeleteTradeFeeCommand : IRequest
    {
        public int TradeSecurityFeeId { get; set; }
    }
}
