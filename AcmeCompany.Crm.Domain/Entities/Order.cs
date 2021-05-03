using System;
using AcmeCompany.Crm.Domain.Common;

namespace AcmeCompany.Crm.Domain.Entities
{
    public class Order: AuditEntity
    {
        public Guid Id { get; set; }
        public Decimal Amount { get; set; }
        public bool Paid { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}