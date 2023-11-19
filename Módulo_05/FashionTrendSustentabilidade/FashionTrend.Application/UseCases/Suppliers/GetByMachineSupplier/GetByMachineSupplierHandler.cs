using AutoMapper;
using MediatR;

public class GetByMachineSupplierHandler : IRequestHandler<GetByMachineSupplierRequest, IEnumerable<GetByMachineSupplierResponse>>
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public GetByMachineSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
    }
    public async Task<IEnumerable<GetByMachineSupplierResponse>> Handle(GetByMachineSupplierRequest request, CancellationToken cancellationToken)
    {
        var supplierMachine = await _supplierRepository.GetByMachines(request.Machine, cancellationToken);
        return _mapper.Map<IEnumerable<GetByMachineSupplierResponse>>(supplierMachine);
    }
}