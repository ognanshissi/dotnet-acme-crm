using System;

namespace AcmeCompany.Crm.Application.Features.Clients.Queries.GetClients
{
    public class GetClientVm
    {
        public Guid Id { get;  }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}