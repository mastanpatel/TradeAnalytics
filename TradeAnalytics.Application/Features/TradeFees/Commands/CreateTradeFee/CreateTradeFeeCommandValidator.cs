using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TradeAnalytics.Application.Features.TradeSecurities.Commands.CreateTradeSecurity;

namespace TradeAnalytics.Application.Features.TradeFees.Commands.CreateTradeFee
{
    public class CreateTradeFeeCommandValidator : AbstractValidator<CreateTradeFeeCommand>
    {
        public CreateTradeFeeCommandValidator()
        {
            

        }

    }
}
