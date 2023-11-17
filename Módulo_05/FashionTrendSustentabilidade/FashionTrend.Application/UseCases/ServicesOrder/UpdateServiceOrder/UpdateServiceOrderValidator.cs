using FluentValidation;

public sealed class UpdateServiceOrderValidator : AbstractValidator<UpdateServiceOrderRequest>
{
    public UpdateServiceOrderValidator()
    {
        RuleFor(x => x.supplierId).NotEmpty();
        RuleFor(x => x.status).NotEmpty();
    }
}