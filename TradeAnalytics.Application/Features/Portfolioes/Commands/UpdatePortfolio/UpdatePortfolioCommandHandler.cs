using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Application.Exceptions;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.Portfolioes.Commands.UpdatePortfolio
{
    public class UpdatePortfolioCommandHandler : IRequestHandler<UpdatePortfolioCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Portfolio> _portfolioRepository;

        public UpdatePortfolioCommandHandler(IMapper mapper, IAsyncRepository<Portfolio> portfolioRepository)
        {
            _mapper = mapper;
            _portfolioRepository = portfolioRepository;
        }
        public async Task<Unit> Handle(UpdatePortfolioCommand request, CancellationToken cancellationToken)
        {
            var portfolioToUpdate = await _portfolioRepository.GetByIdAsync(request.PortfolioId);

            if (portfolioToUpdate == null)
            {
                throw new NotFoundException(nameof(Portfolio), request.PortfolioId.ToString());

            }

            var validator = new UpdatePortfolioCommandValidator();
            var validateResult = await validator.ValidateAsync(request);

            if (validateResult.Errors.Count > 0)
            {
                throw new ValidationException(validateResult);
            }

            _mapper.Map(request, portfolioToUpdate, typeof(UpdatePortfolioCommand), typeof(Portfolio));

            await _portfolioRepository.UpdateAsync(portfolioToUpdate);

            return Unit.Value;


        }
    }
}
