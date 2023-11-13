using AutoMapper;
using MediatR;

public class GetAllServiceOrderHandler : IRequestHandler<GetAllServiceOrderRequest, List<GetAllServiceOrderResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;

    public GetAllServiceOrderHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _serviceOrderRepository = serviceOrderRepository;
    }
    public async Task<List<GetAllServiceOrderResponse>> Handle(GetAllServiceOrderRequest request, CancellationToken cancellationToken)
    {
        var serviceOrder = await _serviceOrderRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllServiceOrderResponse>>(serviceOrder);
    }
}