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

namespace TradeAnalytics.Application.Features.Portfolioes
{
    public class GetPortfolioListQueryHandler : IRequestHandler<GetPortfolioListQuery, List<PortfolioListVm>>
    {
        private readonly IAsyncRepository<Portfolio> _portfolioRepository;
        private readonly IMapper _mapper;
        public GetPortfolioListQueryHandler(IMapper mapper, IAsyncRepository<Portfolio> portfolioRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
        }
        public async Task<List<PortfolioListVm>> Handle(GetPortfolioListQuery request, CancellationToken cancellationToken)
        {
            var allPortfolioes = (await _portfolioRepository.ListAllAsync()).OrderBy(x => x.LastModifiedDate);
            return _mapper.Map<List<PortfolioListVm>>(allPortfolioes);
        }
    }
}
