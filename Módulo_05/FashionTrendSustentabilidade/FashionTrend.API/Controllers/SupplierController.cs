using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FashionTrend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        IMediator _mediator;

        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceContractRequest request)
        {
            var user = await _mediator.Send(request);
            return Ok(user);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateSupplierResponse>>Update(
                                            Guid id, UpdateSupplierRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest("Informe o Id");
            }
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        [HttpGet]
        public async Task<ActionResult<List<GetAllSupplierResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = _mediator.Send(new GetAllSupplierRequest(), cancellationToken);
            return Ok(response);
        }
        //[HttpGet("{id}")]
        //public async Task<ActionResult<List<GetSupplierResponse>>> Get(Guid Id, GetSupplierRequest request, 
        //                                                                            CancellationToken cancellationToken)
        //{
        //   if(Id != request.Id)
        //   {
        //        return BadRequest();
        //   }
        //    var response = await _mediator.Send(request, cancellationToken);
        //    return Ok(response);
        //}
    }
}
