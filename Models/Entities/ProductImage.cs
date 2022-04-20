using System;
using System.Collections.Generic;

namespace DingjiaHpmc.Models.Entities
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int? Product { get; set; }

        public virtual Product? ProductNavigation { get; set; }
    }
}
