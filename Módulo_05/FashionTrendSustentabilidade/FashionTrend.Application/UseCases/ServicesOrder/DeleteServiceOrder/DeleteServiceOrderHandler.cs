using AutoMapper;
using MediatR;

public class DeleteServiceOrderHandler : IRequestHandler<DeleteServiceOrderRequest, DeleteServiceOrderResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _serviceOrderRepository;
    private readonly IMapper _mapper;

    public DeleteServiceOrderHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper)
    {
        _mapper = mapper;
        _serviceOrderRepository = supplierRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<DeleteServiceOrderResponse> Handle(DeleteServiceOrderRequest request, CancellationToken cancellationToken)
    {
        var serviceOrder = await _serviceOrderRepository.Get(request.Id, cancellationToken);

        if (serviceOrder is null) return default;

        _serviceOrderRepository.Delete(serviceOrder);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeleteServiceOrderResponse>(serviceOrder);
    }
}