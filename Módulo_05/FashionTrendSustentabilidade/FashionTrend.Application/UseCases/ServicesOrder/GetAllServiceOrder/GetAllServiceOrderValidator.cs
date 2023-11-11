using FluentValidation;

namespace FashionTrend.Application.UseCases.ServicesOrder.GetAllServiceOrder
{
    public class GetAllServiceOrderValidator : AbstractValidator<GetAllServiceOrderRequest>
    {
        public GetAllServiceOrderValidator()
        {
        }
    }
}