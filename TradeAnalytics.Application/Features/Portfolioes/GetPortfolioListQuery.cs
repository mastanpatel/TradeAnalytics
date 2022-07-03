using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes
{
    public class GetPortfolioListQuery : IRequest<List<PortfolioListVm>>
    {
    }
}
