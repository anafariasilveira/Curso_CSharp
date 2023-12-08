using MediatR;

public sealed record GetByStatusRequest(EContractStatus Status) : IRequest<GetByStatusResponse>;