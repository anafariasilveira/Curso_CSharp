using FluentValidation;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
{
    public class GetAllServiceOrderValidator : AbstractValidator<GetAllServiceOrderRequest>
    {
        public GetAllServiceOrderValidator()
        {
        }
    }
}