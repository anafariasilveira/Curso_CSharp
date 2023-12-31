﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;

public class UpdateServiceOrderHandler : IRequestHandler<UpdateServiceOrderRequest, UpdateServiceOrderResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceOrderRepository _serviceOrderRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<UpdateServiceOrderHandler> _logger;

    public UpdateServiceOrderHandler(IUnitOfWork unitOfWork, IServiceOrderRepository serviceOrderRepository, IMapper mapper, ILogger<UpdateServiceOrderHandler> logger)
    {
        _mapper = mapper;
        _serviceOrderRepository = serviceOrderRepository;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }
    public async Task<UpdateServiceOrderResponse> Handle(UpdateServiceOrderRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var serviceOrder = await _serviceOrderRepository.Get(request.Id, cancellationToken);

            if (serviceOrder is null)
                throw new ArgumentException("ServiceOrder não encontrado");

            serviceOrder.Status = request.Status;

            if (serviceOrder.Status == EContractStatus.Completed)
                serviceOrder.Payment = true;

            _serviceOrderRepository.Update(serviceOrder);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateServiceOrderResponse>(serviceOrder);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ocorreu um erro no método Update ServiceOrder por ID.", request.Id);
            throw;
        }
    }
}