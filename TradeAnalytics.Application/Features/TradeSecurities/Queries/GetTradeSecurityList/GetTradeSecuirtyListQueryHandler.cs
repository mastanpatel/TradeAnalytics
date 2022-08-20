using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityList
{
    public class GetTradeSecuirtyListQueryHandler : IRequestHandler<GetTradeSecuirtyListQuery, List<TradeSecurityListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurity> _tradeSecurityRepository;

        public GetTradeSecuirtyListQueryHandler(IMapper mapper, IAsyncRepository<TradeSecurity> tradeSecurityRepository)
        {
            _mapper = mapper;
            _tradeSecurityRepository = tradeSecurityRepository;
        }
        public async Task<List<TradeSecurityListVm>> Handle(GetTradeSecuirtyListQuery request, CancellationToken cancellationToken)
        {
              var tradeSecurityList = (await _tradeSecurityRepository.ListAllAsync()).OrderBy(x => x.LastModifiedDate);

            return _mapper.Map<List<TradeSecurityListVm>>(tradeSecurityList);
        }
    }
}
