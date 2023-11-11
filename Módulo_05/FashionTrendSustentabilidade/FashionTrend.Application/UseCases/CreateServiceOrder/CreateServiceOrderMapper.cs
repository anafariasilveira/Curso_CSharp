using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
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