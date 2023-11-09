using FluentValidation;

namespace FashionTrend.Application.UseCases.CreateSupplier
{
    public sealed class CreateSupplierValidator : AbstractValidator<CreateSupplierRequest>
    {
        public CreateSupplierValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().MinimumLength(3).EmailAddress();
        }
    }
}