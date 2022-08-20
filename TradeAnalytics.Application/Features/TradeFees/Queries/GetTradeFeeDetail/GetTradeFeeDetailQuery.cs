using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail
{
    public class GetTradeFeeDetailQuery : IRequest<TradeFeeDetailVm>
    {
        public int Id { get; set; }
    }
}
