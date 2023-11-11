﻿using AutoMapper;
using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using MediatR;

namespace FashionTrend.Application.UseCases.Contracts.CreateServiceContract
{
    public class CreateServiceContractHandler : IRequestHandler<CreateServiceContractRequest, CreateServiceContractResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceContractRepository _serviceContractRepository;
        private readonly IMapper _mapper;

        public CreateServiceContractHandler(IUnitOfWork unitOfWork, IServiceContractRepository serviceContractRepository, IMapper mapper)
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
}