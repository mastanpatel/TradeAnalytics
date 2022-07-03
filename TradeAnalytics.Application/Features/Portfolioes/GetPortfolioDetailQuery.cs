using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes
{
    public class GetPortfolioDetailQuery : IRequest<PortfolioDetailVm>
    {
        public Guid Id { get; set; }
    }
}
