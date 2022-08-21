using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TradeAnalytics.Application.Contracts.Persistance;
using TradeAnalytics.Application.Exceptions;
using TradeAnalytics.Application.Features.TradeFees.Commands.DeleteTradeFee;
using TradeAnalytics.Domain.Entities;
using TradeAnalytics.Domain.Entities.TradeFee;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.DeleteTradeFee
{
    public class DeleteTradeFeeCommandHandler : IRequestHandler<DeleteTradeFeeCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<TradeSecurityFee> _tradeSecurityFeeRepository;

        public DeleteTradeFeeCommandHandler(IMapper mapper, IAsyncRepository<TradeSecurityFee> tradeSecurityFeeRepository)
        {
            _mapper = mapper;
            _tradeSecurityFeeRepository = tradeSecurityFeeRepository;
        }
        public async Task<Unit> Handle(DeleteTradeFeeCommand request, CancellationToken cancellationToken)
        {
            var tradeSecurityToDelete = await _tradeSecurityFeeRepository.GetByIdAsync(request.TradeSecurityFeeId);

            if (tradeSecurityToDelete == null)
            {
                throw new NotFoundException(nameof(TradeSecurityFee), request.TradeSecurityFeeId.ToString());
            }

            await _tradeSecurityFeeRepository.DeleteAsync(tradeSecurityToDelete);

            return Unit.Value;
        }
    }
}
