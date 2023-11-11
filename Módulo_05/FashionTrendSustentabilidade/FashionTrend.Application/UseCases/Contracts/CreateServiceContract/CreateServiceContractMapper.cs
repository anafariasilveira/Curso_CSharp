using FashionTrend.Domain.Entities;
using AutoMapper;

namespace FashionTrend.Application.UseCases.Contracts.CreateServiceContract
{
    public class CreateServiceContractMapper : Profile
    {
        public CreateServiceContractMapper()
        {
            CreateMap<CreateServiceContractRequest, ServiceContract>();
            CreateMap<ServiceContract, CreateServiceContractResponse>();
        }

    }
}
