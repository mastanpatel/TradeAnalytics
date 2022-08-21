using AutoMapper;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Features.TradeFees.Queries.GetTradeFeeDetail
{
    public class GetTradeFeeDetailQueryHandler : IRequestHandler<GetTradeFeeDetailQuery, TradeFeeDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurityFee> _tradeSecurityFeeRepository;
        private readonly IAsyncRepository<StampDuty> _stampDutyRepository;
        private readonly IAsyncRepository<Brokerage> _brokerageRepository;

        public GetTradeFeeDetailQueryHandler(IMapper mapper, IAsyncRepository<TradeSecurityFee> tradeSecurityFeeRepository, 
            IAsyncRepository<StampDuty> stampDutyRepository, IAsyncRepository<Brokerage> brokerageRepository)
        {
            _mapper = mapper;
            _tradeSecurityFeeRepository = tradeSecurityFeeRepository;
            _stampDutyRepository = stampDutyRepository;
            _brokerageRepository = brokerageRepository;
        }
        public async Task<TradeFeeDetailVm> Handle(GetTradeFeeDetailQuery request, CancellationToken cancellationToken)
        {
            var tradeSecurityFeeDetail = await _tradeSecurityFeeRepository.GetByIdAsync(request.Id);

            var tradeSecurityFeeDetailDto = _mapper.Map<TradeFeeDetailVm>(tradeSecurityFeeDetail);

            var allBrokarage = (await _brokerageRepository.ListAllAsync()).Where(x => x.TradeSecurityFeeId == tradeSecurityFeeDetail.TradeSecurityFeeId);
            var allStampDuty = (await _stampDutyRepository.ListAllAsync()).Where(x => x.TradeSecurityFeeId == tradeSecurityFeeDetail.TradeSecurityFeeId);

            if (allBrokarage.FirstOrDefault().BrokerageId > 0)
            {
                tradeSecurityFeeDetailDto.Brokerage = _mapper.Map<BrokerageDto>(allBrokarage.FirstOrDefault());
            }
            if (allStampDuty != null)
            {
                tradeSecurityFeeDetailDto.StampDuty = _mapper.Map<StampDutyDto>(allStampDuty.FirstOrDefault());
            }
            if (allBrokarage.FirstOrDefault().BrokerageId == 0)
            {
                tradeSecurityFeeDetailDto.Brokerage = new BrokerageDto();
            }
            if (allStampDuty == null)
            {
                tradeSecurityFeeDetailDto.StampDuty = new StampDutyDto();
            }

            return tradeSecurityFeeDetailDto;

        }
    }
}
