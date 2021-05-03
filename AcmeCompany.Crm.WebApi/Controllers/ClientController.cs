using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AcmeCompany.Crm.Application.Features.Clients.Queries.GetClients;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AcmeCompany.Crm.WebApi.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetClientVm>>> Get(CancellationToken cancellationToken)
        {
            var getClientsQuery = new GetClientsQuery();
            var clients = await _mediator.Send(getClientsQuery);
            return Ok(clients);
        }
    }
}