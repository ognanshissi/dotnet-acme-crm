using System.Collections.Generic;
using MediatR;

namespace AcmeCompany.Crm.Application.Features.Clients.Queries.GetClients
{
    public class GetClientsQuery: IRequest<IEnumerable<GetClientVm>>
    {
        
    }
}