using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioDetail
{
    public class GetPortfolioDetailQuery : IRequest<PortfolioDetailVm>
    {
        public int Id { get; set; }
    }
}
