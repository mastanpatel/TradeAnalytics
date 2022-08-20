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

namespace TradeAnalytics.Application.Features.TradeSecurities.Queries.GetTradeSecurityDetail
{
    public class GetTradeSecurityDetailQueryHandler : IRequestHandler<GetTradeSecurityDetailQuery, TradeSecurityDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurity> _tradeSecurityRepository;
        //private readonly IAsyncRepository<TradeSecurityFundamentals> _tradeSecurityFundamentsRepository;
        //private readonly IAsyncRepository<TradeSecurityPerformance> _tradeSecurityPerformanceRepository;

        public GetTradeSecurityDetailQueryHandler(IMapper mapper, IAsyncRepository<TradeSecurity> tradeSecurityRepository)
        {
            _mapper = mapper;
            _tradeSecurityRepository = tradeSecurityRepository;
        }
        public async Task<TradeSecurityDetailVm> Handle(GetTradeSecurityDetailQuery request, CancellationToken cancellationToken)
        {
            var tradeSecurityDetail = await _tradeSecurityRepository.GetByIdAsync(request.Id);

            var tradeSecurityDetailDto = _mapper.Map<TradeSecurityDetailVm>(tradeSecurityDetail);

            var allTradedSecurityPerformance = (await _tradeSecurityRepository.ListAllAsync()).Where(x => x.TradeSecurityId == tradeSecurityDetail.TradeSecurityId);
            var allTradedSecurityFundamentals = (await _tradeSecurityRepository.ListAllAsync()).Where(x => x.TradeSecurityId == tradeSecurityDetail.TradeSecurityId);

            tradeSecurityDetailDto.TradeSecurityFundamentals = _mapper.Map<List<TradeSecurityFundamentalsDto>>(allTradedSecurityFundamentals);
            tradeSecurityDetailDto.TradeSecurityPerformance = _mapper.Map<List<TradeSecurityPerformanceDto>>(allTradedSecurityPerformance);

            return tradeSecurityDetailDto;


        }
    }
}
