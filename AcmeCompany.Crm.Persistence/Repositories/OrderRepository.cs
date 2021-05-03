using AcmeCompany.Crm.Application.Contracts.Persistence;
using AcmeCompany.Crm.Domain.Entities;

namespace AcmeCompany.Crm.Persistence.Repositories
{
    public class OrderRepository: BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(CrmDbContext context) : base(context)
        {
        }
    }
}