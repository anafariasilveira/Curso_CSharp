using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class GetBySupplierIdHandler : IRequestHandler<GetBySupplierIdRequest, List<GetBySupplierIdResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetBySupplierIdHandler> _logger;

    public GetBySupplierIdHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository, IMapper mapper, ILogger<GetBySupplierIdHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _serviceOrderRepository = serviceOrderRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<List<GetBySupplierIdResponse>> Handle(GetBySupplierIdRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var serviceOrder = await _serviceOrderRepository.GetBySupplierId(request.SupplierId, cancellationToken);

            if (serviceOrder is null)
                throw new ArgumentException("ServiceOrders não encontrados");

            return _mapper.Map<List<GetBySupplierIdResponse>>(serviceOrder);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método Get ServiceOrder por SupplierId.", request.SupplierId);
            throw;
        }

    }
}