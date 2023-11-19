using AutoMapper;
using MediatR;

public class GetByTypeHandler : IRequestHandler<GetByTypeRequest, IEnumerable<GetByTypeResponse>>
{
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;

    public GetByTypeHandler(IServiceOrderRepository serviceOrderRepository, IMapper mapper)
    {
        _mapper = mapper;
        _serviceOrderRepository = serviceOrderRepository;
    }
    public async Task<IEnumerable<GetByTypeResponse>> Handle(GetByTypeRequest request, CancellationToken cancellationToken)
    {
        var type = await _serviceOrderRepository.GetByType(request.Type, cancellationToken);
        return _mapper.Map<IEnumerable<GetByTypeResponse>>(type);
    }
}