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
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeList
{
    public class GetTradeFeeListQueryHandler : IRequestHandler<GetTradeFeeListQuery, List<TradeFeeListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurityFee> _tradeSecurityFeeRepository;

        public GetTradeFeeListQueryHandler(IMapper mapper, IAsyncRepository<TradeSecurityFee> tradeSecurityFeeRepository)
        {
            _mapper = mapper;
            _tradeSecurityFeeRepository = tradeSecurityFeeRepository;
        }
        public async Task<List<TradeFeeListVm>> Handle(GetTradeFeeListQuery request, CancellationToken cancellationToken)
        {
              var tradeSecurityFeeList = (await _tradeSecurityFeeRepository.ListAllAsync()).OrderBy(x => x.LastModifiedDate);

            return _mapper.Map<List<TradeFeeListVm>>(tradeSecurityFeeList);
        }
    }
}
