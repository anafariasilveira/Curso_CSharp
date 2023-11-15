using AutoMapper;
using MediatR;

public class DeleteSupplierHandler : IRequestHandler<DeleteSupplierRequest, DeleteSupplierResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public DeleteSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<DeleteSupplierResponse> Handle(DeleteSupplierRequest request, CancellationToken cancellationToken)
    {
        var supplier = await _supplierRepository.Get(request.Id, cancellationToken);

        if (supplier is null) return default;

        _supplierRepository.Delete(supplier);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<DeleteSupplierResponse>(supplier);
    }
}