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

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail
{
    public class GetTradeFeeDetailQueryHandler : IRequestHandler<GetTradeFeeDetailQuery, TradeFeeDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurityFee> _tradeSecurityFeeRepository;
        //private readonly IAsyncRepository<TradeSecurityFundamentals> _tradeSecurityFundamentsRepository;
        //private readonly IAsyncRepository<TradeSecurityPerformance> _tradeSecurityPerformanceRepository;

        public GetTradeFeeDetailQueryHandler(IMapper mapper, IAsyncRepository<TradeSecurityFee> tradeSecurityFeeRepository)
        {
            _mapper = mapper;
            _tradeSecurityFeeRepository = tradeSecurityFeeRepository;
        }
        public async Task<TradeFeeDetailVm> Handle(GetTradeFeeDetailQuery request, CancellationToken cancellationToken)
        {
            var tradeSecurityFeeDetail = await _tradeSecurityFeeRepository.GetByIdAsync(request.Id);

            var tradeSecurityFeeDetailDto = _mapper.Map<TradeFeeDetailVm>(tradeSecurityFeeDetail);

            var allBrokarage = (await _tradeSecurityFeeRepository.ListAllAsync()).Where(x => x.TradeSecurityFeeId == tradeSecurityFeeDetail.TradeSecurityFeeId);
            var allStampDuty = (await _tradeSecurityFeeRepository.ListAllAsync()).Where(x => x.TradeSecurityFeeId == tradeSecurityFeeDetail.TradeSecurityFeeId);

            tradeSecurityFeeDetailDto.Brokerage = _mapper.Map<BrokerageDto>(allBrokarage);
            tradeSecurityFeeDetailDto.StampDuty = _mapper.Map<StampDutyDto>(allStampDuty);

            return tradeSecurityFeeDetailDto;


        }
    }
}
