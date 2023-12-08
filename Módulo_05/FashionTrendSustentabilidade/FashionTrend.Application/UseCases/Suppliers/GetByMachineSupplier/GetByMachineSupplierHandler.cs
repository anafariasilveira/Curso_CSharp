using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class GetByMachineSupplierHandler : IRequestHandler<GetByMachineSupplierRequest, IEnumerable<GetByMachineSupplierResponse>>
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetByMachineSupplierHandler> _logger;

    public GetByMachineSupplierHandler(ISupplierRepository supplierRepository, IMapper mapper, ILogger<GetByMachineSupplierHandler> logger)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
        _logger = logger;
    }
    public async Task<IEnumerable<GetByMachineSupplierResponse>> Handle(GetByMachineSupplierRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var supplierMachine = await _supplierRepository.GetByMachine(request.Machine, cancellationToken);

            if (supplierMachine is null)
                throw new ArgumentException("Suppliers não encontrados");

            return _mapper.Map<IEnumerable<GetByMachineSupplierResponse>>(supplierMachine);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método de GetByMachine do Supplier.");
            throw;
        }
    }
}