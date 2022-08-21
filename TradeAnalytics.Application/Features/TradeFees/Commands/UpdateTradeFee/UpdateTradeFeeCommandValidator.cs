using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.UpdateTradeFee
{
    public class UpdateTradeFeeCommandValidator : AbstractValidator<UpdateTradeFeeCommand>
    {
        public UpdateTradeFeeCommandValidator()
        {

        }
    }
}
