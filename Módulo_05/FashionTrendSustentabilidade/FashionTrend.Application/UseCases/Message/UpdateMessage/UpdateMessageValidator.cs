using FluentValidation;

public sealed class UpdateMessageValidator : AbstractValidator<UpdateMessageRequest>
{
    public UpdateMessageValidator()
    {
        RuleFor(x => x.topic).NotEmpty();
        RuleFor(x => x.content).NotEmpty();
    }
}