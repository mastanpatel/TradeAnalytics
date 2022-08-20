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

namespace TradeAnalytics.Application.Features.TradeSecurities.Commands.UpdateTradeSecurity
{
    public class UpdateTradeSecurityCommandHandler : IRequestHandler<UpdateTradeSecurityCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurity> _tradeSecurityRepository;

        public UpdateTradeSecurityCommandHandler(IMapper mapper, IAsyncRepository<TradeSecurity> tradeSecurityRepository)
        {
            _mapper = mapper;
            _tradeSecurityRepository = tradeSecurityRepository;
        }
        public async Task<Unit> Handle(UpdateTradeSecurityCommand request, CancellationToken cancellationToken)
        {
            var tradeSecurityToUpdate = await _tradeSecurityRepository.GetByIdAsync(request.Id);

            if (tradeSecurityToUpdate == null)
            {
                throw new NotFoundException(nameof(TradeSecurity), request.Id.ToString());

            }

            var validator = new UpdateTradeSecurityCommandValidator();
            var validateResult = await validator.ValidateAsync(request);

            if (validateResult.Errors.Count > 0)
            {
                throw new ValidationException(validateResult);
            }

            _mapper.Map(request, tradeSecurityToUpdate, typeof(UpdateTradeSecurityCommand), typeof(TradeSecurity));

            await _tradeSecurityRepository.UpdateAsync(tradeSecurityToUpdate);

            return Unit.Value;
        }
    }
}
