using MediatR;

public sealed record GetByIdSupplierRequest(Guid Id) : IRequest<GetByIdSupplierResponse>;