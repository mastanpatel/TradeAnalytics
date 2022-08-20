using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityList;

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeList
{
    public class GetTradeFeeListQuery : IRequest<List<TradeFeeListVm>>
    {
    }
}
