using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class GetAllServiceOrderHandler : IRequestHandler<GetAllServiceOrderRequest, List<GetAllServiceOrderResponse>>
{
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetAllServiceOrderHandler> _logger;

    public GetAllServiceOrderHandler(IServiceOrderRepository serviceOrderRepository, IMapper mapper, ILogger<GetAllServiceOrderHandler> logger)
    {
        _mapper = mapper;
        _serviceOrderRepository = serviceOrderRepository;
        _logger = logger;
    }
    public async Task<List<GetAllServiceOrderResponse>> Handle(GetAllServiceOrderRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var serviceOrder = await _serviceOrderRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllServiceOrderResponse>>(serviceOrder);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método de GetAll do ServiceOrder.");
            throw;
        }
    }
}