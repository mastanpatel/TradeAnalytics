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
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.UpdateTradeFee
{
    public class UpdateTradeFeeCommandHandler : IRequestHandler<UpdateTradeFeeCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurityFee> _tradeSecurityFeeRepository;

        public UpdateTradeFeeCommandHandler(IMapper mapper, IAsyncRepository<TradeSecurityFee> tradeSecurityFeeRepository)
        {
            _mapper = mapper;
            _tradeSecurityFeeRepository = tradeSecurityFeeRepository;
        }
        public async Task<Unit> Handle(UpdateTradeFeeCommand request, CancellationToken cancellationToken)
        {
            var tradeSecurityFeeToUpdate = await _tradeSecurityFeeRepository.GetByIdAsync(request.TradeSecurityFeeId);

            if (tradeSecurityFeeToUpdate == null)
            {
                throw new NotFoundException(nameof(TradeSecurityFee), request.TradeSecurityFeeId.ToString());

            }

            var validator = new UpdateTradeFeeCommandValidator();
            var validateResult = await validator.ValidateAsync(request);

            if (validateResult.Errors.Count > 0)
            {
                throw new ValidationException(validateResult);
            }

            _mapper.Map(request, tradeSecurityFeeToUpdate, typeof(UpdateTradeFeeCommand), typeof(TradeSecurityFee));

            await _tradeSecurityFeeRepository.UpdateAsync(tradeSecurityFeeToUpdate);

            return Unit.Value;
        }
    }
}
