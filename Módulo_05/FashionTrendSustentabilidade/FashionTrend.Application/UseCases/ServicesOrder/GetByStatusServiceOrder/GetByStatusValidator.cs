using FluentValidation;

public sealed class GetByStatusValidator : AbstractValidator<GetByStatusRequest>
{
    public GetByStatusValidator()
    {
        RuleFor(x => x.Status).NotEmpty();
    }
}