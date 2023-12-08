using MediatR;

public sealed record GetByTypeRequest(ERequestType Type) : IRequest<List<GetByTypeResponse>>;