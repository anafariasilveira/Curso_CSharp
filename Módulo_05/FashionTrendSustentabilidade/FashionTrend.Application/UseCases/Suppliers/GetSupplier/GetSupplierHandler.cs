using AutoMapper;
using MediatR;

public class GetSupplierHandler : IRequestHandler<GetSupplierRequest, GetSupplierResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public GetSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<GetSupplierResponse> Handle(GetSupplierRequest request, CancellationToken cancellationToken)
    {
        var supplier = await _supplierRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<GetSupplierResponse>(supplier);
    }
}