using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes.Commands.CreatePortfolio
{
    public class CreatePortfolioCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public bool IsActive { get; set; }
    }
}
