﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FashionTrend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceContractController : ControllerBase
    {
        IMediator _mediator;

        public ServiceContractController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateServiceContractRequest request)
        {
            var serviceContract = await _mediator.Send(request);
            return Ok(serviceContract);

        }
    }
}
