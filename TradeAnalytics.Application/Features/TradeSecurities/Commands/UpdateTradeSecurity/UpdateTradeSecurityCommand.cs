using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeSecurities.Commands.UpdateTradeSecurity
{
    public class UpdateTradeSecurityCommand : IRequest
    {
        public int TradeSecurityId { get; set; }
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string SecurityCode { get; set; }
        public string Desc { get; set; }
    }
}
