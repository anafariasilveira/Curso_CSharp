using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class GetByStatusHandler : IRequestHandler<GetByStatusRequest, List<GetByStatusResponse>>
{
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetBySupplierIdHandler> _logger;

    public GetByStatusHandler(IServiceOrderRepository serviceOrderRepository, IMapper mapper, ILogger<GetBySupplierIdHandler> logger)
    {
        _serviceOrderRepository = serviceOrderRepository;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<List<GetByStatusResponse>> Handle(GetByStatusRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var status = await _serviceOrderRepository.GetByStatus(request.Status, cancellationToken);

            if (status is null)
                throw new ArgumentException("ServiceOrders não encontrados");

            return _mapper.Map<List<GetByStatusResponse>>(status);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método Get ServiceOrder por Status.", request.Status);
            throw;
        }

    }
}