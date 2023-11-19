using FluentValidation;

public class CreateServiceOrderValidator : AbstractValidator<CreateServiceOrderRequest>
{
    public CreateServiceOrderValidator()
    {
       // RuleFor(x => x.SupplierId).NotEmpty();
    }
}