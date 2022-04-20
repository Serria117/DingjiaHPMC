using System;
using System.Collections.Generic;

namespace DingjiaHpmc.Models.Entities
{
    public partial class Content
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Detail { get; set; }
    }
}
