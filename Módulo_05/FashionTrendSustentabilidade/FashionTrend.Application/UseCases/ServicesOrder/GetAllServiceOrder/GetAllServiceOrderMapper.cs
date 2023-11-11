using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases.ServicesOrder.GetAllServiceOrder
{
    public class GetAllServiceOrderMapper : Profile
    {
        public GetAllServiceOrderMapper()
        {
            CreateMap<ServiceOrder, GetAllServiceOrderResponse>();
        }
    }
}