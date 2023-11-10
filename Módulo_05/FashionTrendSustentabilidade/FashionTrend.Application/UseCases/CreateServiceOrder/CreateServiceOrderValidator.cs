using FluentValidation;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
{
    public class CreateServiceOrderValidator : AbstractValidator<CreateServiceOrderRequest>
    {
        public CreateServiceOrderValidator()
        {
            RuleFor(x => x.Status);
        }
    }
}
