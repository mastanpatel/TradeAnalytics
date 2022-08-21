using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.Portfolioes.Commands.CreatePortfolio
{
    public class CreatePortfolioCommandHandler : IRequestHandler<CreatePortfolioCommand, int>
    {
        private readonly IPortfolioRepository _portfolioRepository;
        private readonly IMapper _mapper;
        public CreatePortfolioCommandHandler(IMapper mapper, IPortfolioRepository portfolioRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
        }
        public async Task<int> Handle(CreatePortfolioCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreatePortfolioCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @portfolio = _mapper.Map<Portfolio>(request);

            @portfolio = await _portfolioRepository.AddAsync(@portfolio);

            return portfolio.PortfolioId;
        }
    }
}
