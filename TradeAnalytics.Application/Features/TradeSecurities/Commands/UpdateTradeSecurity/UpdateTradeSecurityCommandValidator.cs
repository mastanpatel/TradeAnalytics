﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.TradeSecurities.Commands.UpdateTradeSecurity
{
    public class UpdateTradeFeeCommandValidator : AbstractValidator<UpdateTradeSecurityCommand>
    {
        public UpdateTradeFeeCommandValidator()
        {

        }
    }
}
