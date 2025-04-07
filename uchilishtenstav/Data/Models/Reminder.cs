using System;
using System.Collections.Generic;

namespace uchilishtenstav.Data.Models
{
    public partial class Reminder
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DueDate { get; set; }
        public int? PropertyId { get; set; }
        public int? PersonId { get; set; }
        public string? Status { get; set; }

        public virtual Person? Person { get; set; }
        public virtual Property? Property { get; set; }
    }
}
