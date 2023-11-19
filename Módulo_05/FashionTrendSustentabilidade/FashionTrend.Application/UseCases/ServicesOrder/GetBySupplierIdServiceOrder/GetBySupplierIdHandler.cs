using AutoMapper;
using MediatR;

public class GetBySupplierIdHandler : IRequestHandler<GetBySupplierIdRequest, GetBySupplierIdResponse>
{
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;

    public GetBySupplierIdHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository, IMapper mapper)
    {
        _mapper = mapper;
        _serviceOrderRepository = serviceOrderRepository;
    }
    public async Task<GetBySupplierIdResponse> Handle(GetBySupplierIdRequest request, CancellationToken cancellationToken)
    {
        var supplierId = await _serviceOrderRepository.GetBySupplierId(request.SupplierId, cancellationToken);
        return _mapper.Map<GetBySupplierIdResponse>(supplierId);
    }
}