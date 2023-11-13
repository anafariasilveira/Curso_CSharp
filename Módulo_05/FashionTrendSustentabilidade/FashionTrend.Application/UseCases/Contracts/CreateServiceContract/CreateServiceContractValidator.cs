using FluentValidation;

public sealed class CreateServiceContractValidator : AbstractValidator<CreateServiceContractRequest>
{
    public CreateServiceContractValidator()
    {
        RuleFor(x => x.StartDate).NotEmpty().Equals(DateTime.Now);
        RuleFor(x => x.EndDate).NotEmpty();
    }
}