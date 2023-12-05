using FluentValidation;

public sealed class GetByTypeValidator : AbstractValidator<GetByTypeRequest>
{
    public GetByTypeValidator()
    {
        RuleFor(x => x.Type).NotEmpty();
    }
}