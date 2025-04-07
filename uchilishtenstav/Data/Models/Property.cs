using System;
using System.Collections.Generic;

namespace uchilishtenstav.Data.Models
{
    public partial class Property
    {
        public Property()
        {
            Contracts = new HashSet<Contract>();
            Images = new HashSet<Image>();
            People = new HashSet<Person>();
            Reminders = new HashSet<Reminder>();
        }

        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string? Kind { get; set; }
        public string Address { get; set; } = null!;
        public string? Exposure { get; set; }
        public int? ConstructionYear { get; set; }
        public string? Floor { get; set; }
        public string? Layout { get; set; }
        public string? Heating { get; set; }
        public string? Notes { get; set; }
        public decimal? Price { get; set; }
        public string? RentConditions { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Reminder> Reminders { get; set; }
    }
}
