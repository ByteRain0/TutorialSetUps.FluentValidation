using FluentValidation.Models;

namespace FluentValidation.Infrastructure.Validators;

public class AddressValidator : AbstractValidator<Address>
{
    public AddressValidator()
    {
        RuleFor(x => x.Street)
            .NotEmpty().When(x => string.IsNullOrEmpty(x.UnstructuredAddress));

        RuleFor(x => x.City)
            .NotEmpty().When(x => string.IsNullOrEmpty(x.UnstructuredAddress));

        RuleFor(x => x.UnstructuredAddress)
            .NotEmpty().When(x => string.IsNullOrEmpty(x.City) || string.IsNullOrEmpty(x.Street));
    }
}