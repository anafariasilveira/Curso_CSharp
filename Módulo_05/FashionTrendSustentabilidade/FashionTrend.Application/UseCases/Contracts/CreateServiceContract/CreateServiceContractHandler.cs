using AutoMapper;
using MediatR;

public class CreateServiceContractHandler : IRequestHandler<CreateServiceContractRequest, CreateServiceContractResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IContractRepository _serviceContractRepository;
    private readonly IMapper _mapper;

    public CreateServiceContractHandler(IUnitOfWork unitOfWork, IContractRepository serviceContractRepository, IMapper mapper)
    {
        _mapper = mapper;
        _serviceContractRepository = serviceContractRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<CreateServiceContractResponse> Handle(CreateServiceContractRequest request, CancellationToken cancellationToken)
    {
        var serviceContract = _mapper.Map<ServiceContract>(request);

        _serviceContractRepository.Create(serviceContract);

        await _unitOfWork.Commit(cancellationToken);
        return _mapper.Map<CreateServiceContractResponse>(serviceContract);
    }
}