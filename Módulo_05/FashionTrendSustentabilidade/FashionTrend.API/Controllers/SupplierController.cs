using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

[Route("api/[controller]")]
[ApiController]
[Consumes(MediaTypeNames.Application.Json)]
public class SupplierController : ControllerBase
{
    IMediator _mediator;

    public SupplierController(IMediator mediator)
    {
        _mediator = mediator;
    }
    /// <summary>
    /// Cria um novo supplier com base nos dados.
    /// </summary>
    /// <param name="request">Dados do fornecedor a serem criados.</param>
    /// <response code="201">Fornecedor criado com sucesso.</response>
    /// <response code="400">Requisição inválida ou erro ao criar o fornecedor.</response>
    [HttpPost]
    public async Task<IActionResult> Create(CreateSupplierRequest request)
    {
        var supplier = await _mediator.Send(request);
        return Ok(supplier);
    }
    /// <summary>
    /// Retorna todos os Suppliers(Fornecedores) cadastrados.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <response code="200">Coleção de Supplier(Fornecedor). Pode ser uma coleção vazia se não houver suppliers cadastrados.</response>
    [HttpGet]
    public async Task<ActionResult<List<GetAllSupplierResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllSupplierRequest(), cancellationToken);
        return Ok(response);
    }
    /// <summary>
    /// Retorna o fornecedor cadastrado por ID.
    /// </summary>
    /// <param name="id">ID do fornecedor</param>
    /// <param name="cancellationToken"></param>
    /// <response code="200">Retorna os dados do fornecedor quando encontrado.</response>
    /// <response code="404">Fornecedor não encontrado.</response>
    [HttpGet("{id}")]
    public async Task<ActionResult<GetByIdSupplierResponse>> Get(Guid? id, CancellationToken cancellationToken)
    {
        if (id is null)
        {
            return BadRequest();
        }

        var request = new GetByIdSupplierRequest(id.Value);
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    /// <summary>
    /// Retorna o fornecedor cadastrado por Email.
    /// </summary>
    /// <param name="email">Email do fornecedor</param>
    /// <param name="cancellationToken"></param>
    /// <response code="200">Retorna os dados do fornecedor quando encontrado.</response>
    /// <response code="404">Fornecedor não encontrado.</response>
    [HttpGet("email/{email}")]
    public async Task<ActionResult<GetByEmailSupplierResponse>> GetByEmail(string email, CancellationToken cancellationToken)
    {
        if (email is null)
        {
            return BadRequest();
        }

        var GetRequest = new GetByEmailSupplierRequest(email.ToLower());
        var response = await _mediator.Send(GetRequest, cancellationToken);
        return Ok(response);
    }
    /// <summary>
    /// Retorna o fornecedor cadastrado por maquina.
    /// </summary>
    /// <param name="machine">Maquina do fornecedor</param>
    /// <param name="cancellationToken"></param>
    /// <response code="200">Retorna os dados do fornecedor quando encontrado.</response>
    /// <response code="404">Fornecedor não encontrado.</response>
    [HttpGet("machine/{machine}")]
    public async Task<ActionResult<GetByMachineSupplierResponse>> GetByMachine
                                            (ESewingMachine machine, CancellationToken cancellationToken)
    {
        var machineRequest = new GetByMachineSupplierRequest(machine);
        var response = await _mediator.Send(machineRequest, cancellationToken);
        return Ok(response);
    }
    /// <summary>
    /// Retorna o fornecedor cadastrado por material.
    /// </summary>
    /// <param name="material">Material do fornecedor</param>
    /// <param name="cancellationToken"></param>
    /// <response code="200">Retorna os dados do fornecedor quando encontrado.</response>
    /// <response code="404">Fornecedor não encontrado.</response>
    [HttpGet("material/{material}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [Produces(MediaTypeNames.Application.Json)]
    public async Task<ActionResult<GetByMaterialSupplierResponse>> GetByMaterial(string material, CancellationToken cancellationToken)
    {
        if (material is null)
        {
            return BadRequest();
        }

        var GetRequest = new GetByMaterialSupplierRequest(material.ToLower());
        var response = await _mediator.Send(GetRequest, cancellationToken);
        return Ok(response);
    }
        /// <summary>
        /// Altera o fornecedor cadastrado pelo Id.
        /// </summary>
        /// <param name="id">Id do fornecedor</param>
        /// <param name="request">Dados do fornecedor a serem alterados.</param>
        /// <param name="cancellationToken"></param>
        /// <response code="404">Fornecedor não encontrado.</response>
        /// <response code="200">Retorna que um fornecedor foi alterado.</response>
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateSupplierResponse>> Update(
                                            Guid id, UpdateSupplierRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
        /// <summary>
        /// Deleta o fornecedor cadastrado pelo Id.
        /// </summary>
        /// <param name="id">Id do fornecedor</param>
        /// <param name="cancellationToken"></param>
        /// <response code="200">Retorna que um fornecedor foi deletado.</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid? id, CancellationToken cancellationToken)
        {
            if (id is null)
            {
                return BadRequest();
            }

            var deleteRequest = new DeleteSupplierRequest(id.Value);
            var response = await _mediator.Send(deleteRequest, cancellationToken);
            return Ok(response);
        }
    } 
}