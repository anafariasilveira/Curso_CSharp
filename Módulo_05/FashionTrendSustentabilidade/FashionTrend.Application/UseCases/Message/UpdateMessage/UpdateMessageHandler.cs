using AutoMapper;
using MediatR;

public class UpdateMessageHandler : IRequestHandler<UpdateMessageRequest, UpdateMessageResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IKafkaProducer _kafkaRepository;
    private readonly IMapper _mapper;

    public UpdateMessageHandler(IUnitOfWork unitOfWork, IKafkaProducer kafkaRepository, IMapper mapper)
    {
        _mapper = mapper;
        _kafkaRepository = kafkaRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task<UpdateMessageResponse> Handle(UpdateMessageRequest request, CancellationToken cancellationToken)
    {
        var message = await _kafkaRepository.ProduceAsync(
           request.topic,
           request.sender,
           request.receiver,
           request.content);

        return _mapper.Map<UpdateMessageResponse>(message);
    }
}