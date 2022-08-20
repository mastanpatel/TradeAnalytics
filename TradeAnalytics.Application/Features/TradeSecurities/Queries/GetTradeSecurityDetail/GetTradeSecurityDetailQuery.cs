using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityDetail
{
    public class GetTradeSecurityDetailQuery : IRequest<TradeSecurityDetailVm>
    {
        public int Id { get; set; }
    }
}
