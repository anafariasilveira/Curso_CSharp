using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class GetByIdSupplierHandler : IRequestHandler<GetByIdSupplierRequest, GetByIdSupplierResponse>
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetByIdSupplierHandler> _logger;

    public GetByIdSupplierHandler(ISupplierRepository supplierRepository, IMapper mapper, ILogger<GetByIdSupplierHandler> logger)
    {
        _mapper = mapper;
        _supplierRepository = supplierRepository;
        _logger = logger;
    }
    public async Task<GetByIdSupplierResponse> Handle(GetByIdSupplierRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var supplier = await _supplierRepository.Get(request.Id, cancellationToken);

            if (supplier == null)
            {
                throw new ArgumentException("Supplier não encontrados.");
            }
            return _mapper.Map<GetByIdSupplierResponse>(supplier);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método de GetById do Supplier.");
            throw;
        }
    }
}