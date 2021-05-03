using AcmeCompany.Crm.Domain.Entities;

namespace AcmeCompany.Crm.Application.Contracts.Persistence
{
    public interface IClientRepository: IAsyncRepository<Client>
    {
        
    }
}