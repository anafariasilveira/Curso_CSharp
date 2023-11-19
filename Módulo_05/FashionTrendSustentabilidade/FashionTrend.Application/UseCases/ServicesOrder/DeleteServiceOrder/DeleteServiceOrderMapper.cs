using AutoMapper;

public class DeleteServiceOrderMapper : Profile
{
    public DeleteServiceOrderMapper()
    {
        CreateMap<CreateServiceOrderRequest, ServiceOrder>();
        CreateMap<ServiceOrder, DeleteServiceOrderResponse>();
    }

}