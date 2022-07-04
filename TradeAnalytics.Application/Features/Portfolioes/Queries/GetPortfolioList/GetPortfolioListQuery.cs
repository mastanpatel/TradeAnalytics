using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioList
{
    public class GetPortfolioListQuery : IRequest<List<PortfolioListVm>>
    {
    }
}
