using AutoMapper;
using MediatR;

public class UpdateServiceOrderHandler : IRequestHandler<UpdateServiceOrderRequest, UpdateServiceOrderResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;

    public UpdateServiceOrderHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository, IMapper mapper)
    {
        _mapper = mapper;
        _serviceOrderRepository = serviceOrderRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<UpdateServiceOrderResponse> Handle(UpdateServiceOrderRequest command, CancellationToken cancellationToken)
    {
        var serviceOrder = await _serviceOrderRepository.Get(command.Id, cancellationToken);

        if (serviceOrder is null) return default;

        serviceOrder.SupplierId = command.supplierId;
        serviceOrder.ServiceId = command.serviceId;
        serviceOrder.EstimatedDate = command.estimateDate;
        serviceOrder.Status = command.status;
        
        _serviceOrderRepository.Update(serviceOrder);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<UpdateServiceOrderResponse>(serviceOrder);
    }
}