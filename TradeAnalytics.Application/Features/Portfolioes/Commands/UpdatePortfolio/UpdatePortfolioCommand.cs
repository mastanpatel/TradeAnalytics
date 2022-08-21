using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes.Commands.UpdatePortfolio
{
    public class UpdatePortfolioCommand : IRequest
    {
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
    }
}
