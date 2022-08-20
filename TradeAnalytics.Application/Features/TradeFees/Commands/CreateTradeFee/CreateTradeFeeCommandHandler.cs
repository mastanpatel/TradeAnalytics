using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.CreateTradeSecurity;
using TradeAnalytics.Domain.Entities;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.CreateTradeFee
{
    public class CreateTradeFeeCommandHandler : IRequestHandler<CreateTradeFeeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurityFee> _tradeSecurityFeeRepository;

        public CreateTradeFeeCommandHandler(IMapper mapper, IAsyncRepository<TradeSecurityFee> tradeSecurityFeeRepository)
        {
            _mapper = mapper;
            _tradeSecurityFeeRepository = tradeSecurityFeeRepository;
        }
        public async Task<int> Handle(CreateTradeFeeCommand request, CancellationToken cancellationToken)
        {
            //validate the data
            var validator = new CreateTradeFeeCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            var @tradeSecurityFee = _mapper.Map<TradeSecurityFee>(request);

            @tradeSecurityFee = await _tradeSecurityFeeRepository.AddAsync(@tradeSecurityFee);

            return @tradeSecurityFee.TradeSecurityFeeId;

        }
    }
}
