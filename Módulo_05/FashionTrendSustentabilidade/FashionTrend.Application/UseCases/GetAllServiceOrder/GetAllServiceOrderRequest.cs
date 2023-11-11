using FashionTrend.Domain.Enums;
using MediatR;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
{
    public sealed record GetAllServiceOrderRequest : IRequest<List<GetAllServiceOrderResponse>>;
}