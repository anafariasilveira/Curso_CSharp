using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class GetByTypeHandler : IRequestHandler<GetByTypeRequest, IEnumerable<GetByTypeResponse>>
{
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetByTypeHandler> _logger;

    public GetByTypeHandler(IServiceOrderRepository serviceOrderRepository, IMapper mapper, ILogger<GetByTypeHandler> logger)
    {
        _mapper = mapper;
        _serviceOrderRepository = serviceOrderRepository;
        _logger = logger;
    }
    public async Task<List<GetByTypeResponse>> Handle(GetByTypeRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var type = await _serviceOrderRepository.GetByType(request.Type, cancellationToken);

            if (type == null)
                throw new ArgumentException("Service Order não encontrada.");

            return _mapper.Map<List<GetByTypeResponse>>(type);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um errno no Service Order por Get Type.");
            throw;
        }
    }
}