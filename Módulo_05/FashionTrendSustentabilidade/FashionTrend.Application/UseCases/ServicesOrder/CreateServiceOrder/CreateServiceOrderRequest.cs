using MediatR;

public sealed record CreateServiceOrderRequest(
        Guid SupplierId,
        Guid ServiceId,
        DateTimeOffset EstimateDate,
        ERequestType Type
        ) : IRequest<CreateServiceOrderResponse>;