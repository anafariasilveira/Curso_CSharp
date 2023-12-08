using MediatR;

public sealed record GetByMaterialSupplierRequest(EMaterial Material) : IRequest<GetByMaterialSupplierResponse>;