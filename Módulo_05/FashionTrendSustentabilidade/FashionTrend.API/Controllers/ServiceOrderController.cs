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
        public async Task<IActionResult> Create(GetAllServiceOrderRequest request)
        {
            var serviceOrder = await _mediator.Send(request);
            return Ok(serviceOrder);

        }
        [HttpGet] 
        public async Task<ActionResult<List<GetAllServiceOrderResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = _mediator.Send(new GetAllServiceOrderRequest(), cancellationToken);
            return Ok(response);
        }
    }
}