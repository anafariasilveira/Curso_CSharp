using AutoMapper;
using MediatR;

public class GetByMachineSupplierHandler : IRequestHandler<GetByMachineSupplierRequest, GetByMachineSupplierResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public GetByMachineSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<GetByMachineSupplierResponse> Handle(GetByMachineSupplierRequest request, CancellationToken cancellationToken)
    {
        var supplierMachine = await _supplierRepository.GetByMachines(request.Machine, cancellationToken);
        return _mapper.Map<GetByMachineSupplierResponse>(supplierMachine);
    }
}