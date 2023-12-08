using MediatR;

public sealed record UpdateServiceOrderRequest(
        Guid Id, EContractStatus Status) : IRequest<UpdateServiceOrderResponse>;