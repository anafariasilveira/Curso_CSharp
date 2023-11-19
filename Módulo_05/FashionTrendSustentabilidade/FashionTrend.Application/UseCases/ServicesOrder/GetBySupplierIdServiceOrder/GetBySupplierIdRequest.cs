using MediatR;

public sealed record GetBySupplierIdRequest(Guid SupplierId) : IRequest<GetBySupplierIdResponse>;