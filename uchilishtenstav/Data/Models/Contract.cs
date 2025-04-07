using System;
using System.Collections.Generic;

namespace uchilishtenstav.Data.Models
{
    public partial class Contract
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int? TenantId { get; set; }
        public int? LandlordId { get; set; }
        public DateTime? ContractDate { get; set; }
        public decimal? Deposit { get; set; }
        public int? PaymentDueDay { get; set; }
        public string? Notes { get; set; }

        public virtual Person? Landlord { get; set; }
        public virtual Property Property { get; set; } = null!;
        public virtual Person? Tenant { get; set; }
    }
}
