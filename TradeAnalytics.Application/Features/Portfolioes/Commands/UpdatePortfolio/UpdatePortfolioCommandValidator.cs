using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeAnalytics.Application.Features.Portfolioes.Commands.UpdatePortfolio
{
    public class UpdatePortfolioCommandValidator : AbstractValidator<UpdatePortfolioCommand>
    {
        public UpdatePortfolioCommandValidator()
        {
            RuleFor(x => x.PortfolioId)
                 .NotEmpty().WithMessage("{PropertyName} is required.")
                 .NotNull();

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters");

            RuleFor(x => x.Desc)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(200).WithMessage("{PropertyName} must not exceed 50 characters");

            RuleFor(x => x.IsActive).Must(x => x == false || x == true);
        }
    }
}
