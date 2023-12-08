using FluentValidation;

public sealed class GetByIdSupplierValidator : AbstractValidator<GetByIdSupplierRequest>
{
    public GetByIdSupplierValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}