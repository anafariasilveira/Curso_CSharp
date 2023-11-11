using MediatR;

namespace FashionTrend.Application.UseCases.ServicesOrder.GetAllServiceOrder
{
    public sealed record GetAllServiceOrderRequest : IRequest<List<GetAllServiceOrderResponse>>;
}