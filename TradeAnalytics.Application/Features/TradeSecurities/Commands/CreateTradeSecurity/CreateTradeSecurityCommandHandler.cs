using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Domain.Entities;

namespace TradeAnalytics.Application.Features.TradeSecurities.Commands.CreateTradeSecurity
{
    public class CreateTradeSecurityCommandHandler : IRequestHandler<CreateTradeSecurityFeeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurity> _tradeSecurityRepository;

        public CreateTradeSecurityCommandHandler(IMapper mapper, IAsyncRepository<TradeSecurity> tradeSecurityRepository)
        {
            _mapper = mapper;
            _tradeSecurityRepository = tradeSecurityRepository;
        }
        public async Task<int> Handle(CreateTradeSecurityFeeCommand request, CancellationToken cancellationToken)
        {
            //validate the data
            var validator = new CreateTradeSecurityCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }
            var @tradeSecurity = _mapper.Map<TradeSecurity>(request);

            @tradeSecurity = await _tradeSecurityRepository.AddAsync(@tradeSecurity);

            return @tradeSecurity.TradeSecurityId;
           
        }
    }
}
