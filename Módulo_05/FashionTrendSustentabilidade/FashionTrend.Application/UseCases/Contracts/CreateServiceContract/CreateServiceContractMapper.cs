using AutoMapper;

public class CreateServiceContractMapper : Profile
{
    public CreateServiceContractMapper()
    {
        CreateMap<CreateServiceContractRequest, ServiceContract>();
        CreateMap<ServiceContract, CreateServiceContractResponse>();
    }

}