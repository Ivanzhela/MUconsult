using System;
using System.Collections.Generic;

namespace uchilishtenstav.Data.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string? Description { get; set; }

        public virtual Property Property { get; set; } = null!;
    }
}
