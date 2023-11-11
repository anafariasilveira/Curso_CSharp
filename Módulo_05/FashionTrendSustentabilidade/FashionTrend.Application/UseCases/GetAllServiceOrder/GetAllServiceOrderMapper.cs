using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases.CreateServiceOrder
{
    public class GetAllServiceOrderMapper : Profile
    {
        public GetAllServiceOrderMapper()
        {
            CreateMap<ServiceOrder, GetAllServiceOrderResponse>();
        }
    }
}