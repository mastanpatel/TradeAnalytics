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

namespace TradeAnalytics.Application.Features.TradeSecurities.Commands.DeleteTradeSecurity
{
    public class DeleteTradeFeeCommandHandler : IRequestHandler<DeleteTradeSecurityCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurity> _tradeSecurityRepository;

        public DeleteTradeFeeCommandHandler(IMapper mapper, IAsyncRepository<TradeSecurity> tradeSecurityRepository)
        {
            _mapper = mapper;
            _tradeSecurityRepository = tradeSecurityRepository;
        }
        public async Task<Unit> Handle(DeleteTradeSecurityCommand request, CancellationToken cancellationToken)
        {
            var tradeSecurityToDelete = await _tradeSecurityRepository.GetByIdAsync(request.TradeSecurityId);

            if (tradeSecurityToDelete == null)
            {
                throw new NotFoundException(nameof(TradeSecurity), request.TradeSecurityId.ToString());
            }

            await _tradeSecurityRepository.DeleteAsync(tradeSecurityToDelete);

            return Unit.Value;
        }
    }
}
