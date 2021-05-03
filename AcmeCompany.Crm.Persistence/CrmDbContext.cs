using AcmeCompany.Crm.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcmeCompany.Crm.Persistence
{
    public class CrmDbContext: DbContext
    {
        public DbSet<Client> Clients {get; set; }
        public DbSet<Order> Orders { get; set; }

        public CrmDbContext(DbContextOptions<CrmDbContext> options): base(options)
        {
            
        }
    }
}