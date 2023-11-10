using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
{
    public class CreateServiceOrderHandler : IRequestHandler<CreateServiceOrderRequest, CreateServiceOrderResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceOrderRepository _serviceOrderRepository;
        private readonly IMapper _mapper;

        public CreateServiceOrderHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;  
            _serviceOrderRepository = serviceOrderRepository;
        }
        public async Task<CreateServiceOrderResponse> Handle(CreateServiceOrderRequest request, CancellationToken cancellationToken)
        {
            var serviceOrder = _mapper.Map<ServiceOrder>(request);
            _serviceOrderRepository.Create(serviceOrder);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateServiceOrderResponse>(serviceOrder);
        }
    }
}
