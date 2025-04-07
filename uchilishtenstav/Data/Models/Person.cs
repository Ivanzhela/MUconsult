using System;
using System.Collections.Generic;

namespace uchilishtenstav.Data.Models
{
    public partial class Person
    {
        public Person()
        {
            ContractLandlords = new HashSet<Contract>();
            ContractTenants = new HashSet<Contract>();
            Reminders = new HashSet<Reminder>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string? SearchPreferences { get; set; }
        public int? RelatedPropertyId { get; set; }

        public virtual Property? RelatedProperty { get; set; }
        public virtual ICollection<Contract> ContractLandlords { get; set; }
        public virtual ICollection<Contract> ContractTenants { get; set; }
        public virtual ICollection<Reminder> Reminders { get; set; }
    }
}
