using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AcmeCompany.Crm.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace AcmeCompany.Crm.Persistence.Repositories
{
    public class BaseRepository<T> : IAsyncRepository<T> where T: class
    {
        protected readonly CrmDbContext _context;

        protected BaseRepository(CrmDbContext context)
        {
            _context = context;
        }
        
        public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken)
        {
            return await _context.Set<T>().ToListAsync();
        }

        
    }
}