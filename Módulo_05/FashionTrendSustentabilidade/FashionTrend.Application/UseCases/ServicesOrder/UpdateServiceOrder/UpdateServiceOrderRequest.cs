using MediatR;

public sealed record UpdateServiceOrderRequest(
        Guid Id,
        Guid supplierId,
        Guid serviceId,
        DateTimeOffset estimateDate,
        EContractStatus status) : IRequest<UpdateServiceOrderResponse>;