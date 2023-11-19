using FluentValidation;

public sealed class GetBySupplierIdValidator : AbstractValidator<GetBySupplierIdRequest>
{
    public GetBySupplierIdValidator()
    {
        RuleFor(x => x.SupplierId).NotEmpty();
    }
}