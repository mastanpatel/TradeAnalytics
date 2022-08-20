using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityList
{
    public class GetTradeSecuirtyListQuery : IRequest<List<TradeFeeListVm>>
    {
    }
}
