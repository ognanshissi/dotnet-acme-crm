using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AcmeCompany.Crm.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T: class
    {
        Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAll(CancellationToken cancellationToken);
    }
}