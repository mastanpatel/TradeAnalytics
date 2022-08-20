using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityDetail
{
    public class GetTradeSecurityDetailQueryHandler : IRequestHandler<GetTradeSecurityDetailQuery, List<TradeSecurityDetailVm>>
    {
        private readonly IMediator _mediator;
        private readonly IAsyncRepository<TradeSecurity> _tradeSecurityRepository;

        public GetTradeSecurityDetailQueryHandler(IMediator mediator, IAsyncRepository<TradeSecurity> tradeSecurityRepository)
        {
            _mediator = mediator;
            _tradeSecurityRepository = tradeSecurityRepository;
        }
        public Task<List<TradeSecurityDetailVm>> Handle(GetTradeSecurityDetailQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
