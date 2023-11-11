using FashionTrend.Domain.Enums;
using MediatR;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
{
    public sealed record CreateServiceOrderRequest(
        Guid SupplierId,
        Guid ServiceId,
        DateTimeOffset EstimateDate,
        ERequestStatus Status
        ) : IRequest<CreateServiceOrderResponse>;
}