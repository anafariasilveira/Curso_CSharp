using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases.ServicesOrder.CreateServiceOrder
{
    public class CreateServiceOrderMapper : Profile
    {
        public CreateServiceOrderMapper()
        {
            CreateMap<CreateServiceOrderRequest, ServiceOrder>();
            CreateMap<ServiceOrder, CreateServiceOrderResponse>();
        }
    }
}