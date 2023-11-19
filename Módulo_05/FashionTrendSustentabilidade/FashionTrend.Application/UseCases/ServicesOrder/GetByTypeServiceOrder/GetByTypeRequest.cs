using MediatR;

public sealed record GetByTypeRequest(ERequestType Type) : IRequest<IEnumerable<GetByTypeResponse>>;