using System;
using System.Collections.Generic;
using AcmeCompany.Crm.Domain.Common;

namespace AcmeCompany.Crm.Domain.Entities
{
    public class Client: AuditEntity
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}