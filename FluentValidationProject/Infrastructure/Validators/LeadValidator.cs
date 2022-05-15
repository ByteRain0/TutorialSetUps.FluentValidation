using FluentValidation.Infrastructure.Validators;
using FluentValidation.Services;

namespace FluentValidation.Models;

public class LeadValidator : AbstractValidator<Lead>
{
    public LeadValidator(IHumanReactionAnalyzer analyzer)
    {
        RuleFor(x => x.Description)
            .NotEmpty();

        RuleFor(x => x.CheckId)
            .NotEmpty().WithMessage("Value '{PropertyValue}' is not allowed for '{PropertyName}'.");

        RuleFor(x => x.ExecutionDurationInDays)
            .GreaterThan(0).WithMessage("Lead cannot take less than a day")
            .LessThan(365).WithMessage("Lead cannot span for more than a year");

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Email)
            .EmailAddress()
            .NotEmpty();

        RuleFor(x => x.PhoneNumber)
            .ValidMoldavianPhone();

        RuleForEach(x => x.Comments)
            .NotEmpty()
            .PositiveComment(analyzer);

        RuleFor(x => x.Address)
            .SetValidator(new AddressValidator());

        RuleForEach(x => x.Comments)
            .MustAsync(async (comment, cancellationToken) =>
            {
                var result = await analyzer.AnalyzeCommentAsync(comment, cancellationToken);

                return result.IsPositive;
            });
    }
}