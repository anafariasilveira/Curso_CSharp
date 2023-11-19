using MediatR;

public sealed record UpdateServiceOrderRequest(
        Guid Id,
        Guid supplierId,
        Guid serviceId,
        DateTimeOffset estimateDate,
        ERequestType type) : IRequest<UpdateServiceOrderResponse>;