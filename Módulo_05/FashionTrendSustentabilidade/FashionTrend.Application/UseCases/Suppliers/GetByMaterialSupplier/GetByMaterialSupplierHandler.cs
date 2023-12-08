using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class GetByMaterialSupplierHandler : IRequestHandler<GetByMaterialSupplierRequest, GetByMaterialSupplierResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetByMaterialSupplierHandler> _logger;

    public GetByMaterialSupplierHandler(IUnitOfWork unitOfWork, ISupplierRepository supplierRepository, IMapper mapper, ILogger<GetByMaterialSupplierHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _supplierRepository = supplierRepository;
        _mapper = mapper;
        _logger = logger;
    }
    public async Task<GetByMaterialSupplierResponse> Handle(GetByMaterialSupplierRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var supplier = await _supplierRepository.GetByMaterial(request.Material, cancellationToken);

            if (supplier is null)
                throw new ArgumentException("Supplier não encontrado");

            return _mapper.Map<GetByMaterialSupplierResponse>(supplier);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método Get Supplier por Material.", request.Material);
            throw;
        }

    }
}