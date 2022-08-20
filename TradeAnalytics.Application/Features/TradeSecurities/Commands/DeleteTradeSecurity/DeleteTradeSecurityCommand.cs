using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeSecurities.Commands.DeleteTradeSecurity
{
    public class DeleteTradeSecurityCommand : IRequest
    {
        public int TradeSecurityId { get; set; }
    }
}
