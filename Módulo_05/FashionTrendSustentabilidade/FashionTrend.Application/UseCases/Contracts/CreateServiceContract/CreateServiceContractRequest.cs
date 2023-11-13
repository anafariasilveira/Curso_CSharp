using MediatR;

public sealed record CreateServiceContractRequest(
     Guid OrderId,
     Guid SupplierId,
     DateTimeOffset StartDate,
     DateTimeOffset EndDate,
     EContractStatus Status) : IRequest<CreateServiceContractResponse>;