using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes.Commands.DeletePortfolio
{
    public class DeletePortfolioCommand : IRequest
    {
        public int PortfolioId { get; set; }
    }
}
