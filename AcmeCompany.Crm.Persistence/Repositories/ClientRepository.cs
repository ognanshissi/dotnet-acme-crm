using AcmeCompany.Crm.Application.Contracts.Persistence;
using AcmeCompany.Crm.Domain.Entities;

namespace AcmeCompany.Crm.Persistence.Repositories
{
    public class ClientRepository: BaseRepository<Client>, IClientRepository
    {
        public ClientRepository(CrmDbContext context) : base(context)
        {
        }
    }
}