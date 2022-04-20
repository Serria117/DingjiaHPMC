using System;
using System.Collections.Generic;

namespace DingjiaHpmc.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public int Category { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public string? Info { get; set; }
        public string? TechDetail { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual Category CategoryNavigation { get; set; } = null!;
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
