using FashionTrend.Domain.Enums;
using MediatR;

namespace FashionTrend.Application.UseCases.ServicesOrder.CreateServiceOrder
{
    public sealed record CreateServiceOrderRequest(
        Guid SupplierId,
        Guid ServiceId,
        DateTimeOffset EstimateDate,
        EContractStatus Status
        ) : IRequest<CreateServiceOrderResponse>;
}