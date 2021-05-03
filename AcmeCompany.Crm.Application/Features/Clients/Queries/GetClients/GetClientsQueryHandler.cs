using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AcmeCompany.Crm.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;

namespace AcmeCompany.Crm.Application.Features.Clients.Queries.GetClients
{
    public class GetClientsQueryHandler: IRequestHandler<GetClientsQuery, IEnumerable<GetClientVm>>
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public GetClientsQueryHandler(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<GetClientVm>> Handle(GetClientsQuery request, CancellationToken cancellationToken)
        {
            var clients = await _clientRepository.GetAll(cancellationToken);
            return _mapper.Map<IEnumerable<GetClientVm>>(clients);
        }
    }
}