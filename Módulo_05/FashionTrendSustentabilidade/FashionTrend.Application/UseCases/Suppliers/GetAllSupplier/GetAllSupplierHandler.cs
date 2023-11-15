using AutoMapper;
using MediatR;

public class GetAllSupplierHandler : IRequestHandler<GetAllSupplierRequest, List<GetAllSupplierResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public GetAllSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<List<GetAllSupplierResponse>> Handle(GetAllSupplierRequest request, CancellationToken cancellationToken)
    {
        var supplier = await _supplierRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAllSupplierResponse>>(supplier);
    }
}