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

namespace TradeAnalytics.Application.Features.Portfolioes.Queries.GetPortfolioDetail
{
    public class GetPortfolioDetailQueryHandler : IRequestHandler<GetPortfolioDetailQuery, PortfolioDetailVm>
    {
        private readonly IAsyncRepository<Portfolio> _portfolioRepository;
        private readonly IAsyncRepository<TradeSecurity> _tradeSecurityRepository;
        private readonly IMapper _mapper;
        public GetPortfolioDetailQueryHandler(IMapper mapper, IAsyncRepository<Portfolio> portfolioRepository, IAsyncRepository<TradeSecurity> tradeSecurityRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
            _tradeSecurityRepository = tradeSecurityRepository;
        }
        public async Task<PortfolioDetailVm> Handle(GetPortfolioDetailQuery request, CancellationToken cancellationToken)
        {
            var @Portfolio = await _portfolioRepository.GetByIdAsync(request.Id);
            var portfolioDetailDto = _mapper.Map<PortfolioDetailVm>(@Portfolio);

            var allTradeSecurity = (await _tradeSecurityRepository.ListAllAsync()).Where(x => x.PortfolioId == @Portfolio.PortfolioId);

            portfolioDetailDto.TradeSecurities = _mapper.Map<List<TradeSecurityDto>>(allTradeSecurity);

            return portfolioDetailDto;
        }
    }
}
