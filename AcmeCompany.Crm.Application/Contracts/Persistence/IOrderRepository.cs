using AcmeCompany.Crm.Domain.Entities;

namespace AcmeCompany.Crm.Application.Contracts.Persistence
{
    public interface IOrderRepository: IAsyncRepository<Order>
    {
        
    }
}