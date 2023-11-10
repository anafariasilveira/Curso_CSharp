using FashionTrend.Application.UseCases.CreateServiceOrder;
using FashionTrend.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FashionTrend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceOrderController : ControllerBase
    {
        IMediator _mediator;
        private readonly IServiceOrderRepository _serviceOrderRepository;

        public ServiceOrderController(IMediator mediator, IServiceOrderRepository serviceOrderRepository)
        {
            _mediator = mediator;
            _serviceOrderRepository = serviceOrderRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceOrderRequest request)
        {
            var serviceOrder = await _mediator.Send(request);
            return Ok(serviceOrder);

        }
        //[HttpGet] // colocar um {id}?
        //public async Task<IActionResult> GetByServiceId()
        //{
        //    var serviceId = await _serviceOrderRepository.GetByServiceId();
        //    if (serviceId.IsSuccess)
        //        return Ok(serviceId);

        //    return BadRequest(serviceId);
        //}
    }
}
