using FluentValidation.Services;

namespace FluentValidation.Models;

public static class CustomValidators
{
    public static IRuleBuilderOptions<T, string> ValidMoldavianPhone<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder.Matches(@"^((003737|003736)([0-9]){7})$")
            .WithMessage("'{PropertyName}' should be a valid phone number for Moldova.");
    }

    public static IRuleBuilderOptions<T, string> PositiveComment<T>(this IRuleBuilder<T, string> ruleBuilder,
        IHumanReactionAnalyzer reactionAnalyzer)
    {
        return ruleBuilder.Must(x => reactionAnalyzer.AnalyzeComment(x).IsPositive)
            .WithMessage("Following comment was not rated as positive feedback : '{PropertyValue}'.");
    }
}