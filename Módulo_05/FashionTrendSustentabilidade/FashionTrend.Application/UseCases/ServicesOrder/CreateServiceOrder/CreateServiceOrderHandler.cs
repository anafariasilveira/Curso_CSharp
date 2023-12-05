using AutoMapper;
using MediatR;

public class CreateServiceOrderHandler : IRequestHandler<CreateServiceOrderRequest, CreateServiceOrderResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IServiceRepository _serviceRepository;

    public CreateServiceOrderHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository, IMapper mapper, ISupplierRepository supplierRepository, IServiceRepository serviceRepository)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _serviceOrderRepository = serviceOrderRepository;
        _supplierRepository = supplierRepository;
        _serviceRepository = serviceRepository;
    }
    public async Task<CreateServiceOrderResponse> Handle(CreateServiceOrderRequest request, CancellationToken cancellationToken)
    {
        var serviceOrder = _mapper.Map<ServiceOrder>(request);

        var service = await _serviceRepository.Get(request.ServiceId, cancellationToken);
        var supplier = await _supplierRepository.Get(request.SupplierId, cancellationToken);

        if (service == null)
        {
            throw new ArgumentException("Service not found!");
        }
        if (supplier == null)
        {
            throw new ArgumentException("Supplier not found");
        }

        var date = DateTime.Now;
        serviceOrder.EstimatedDate = date.AddDays(service.ServiceDays);

        _serviceOrderRepository.Create(serviceOrder);
        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreateServiceOrderResponse>(serviceOrder);
    }
}