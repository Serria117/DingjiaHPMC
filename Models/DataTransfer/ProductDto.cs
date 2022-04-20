using DingjiaHpmc.Models.Entities;

namespace DingjiaHpmc.Models.DataTransfer
{
    public class ProductDto : IDataTransfer<Product, int?>
    {
        public int? Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Code { get; set; }
        public int Category { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public string? Info { get; set; }
        public string? TechDetail { get; set; }
        public ICollection<string>? images { get; set; } = null;
        public DateTime? DateUpdate { get; set; }

        public Product Build(int? id)
        {
            var product = new Product()
            {
                Name = Name,
                Code = Code,
                Category = Category,
                Price = Price,
                TechDetail = TechDetail,
                Info = Info,
                DateUpdate = DateUpdate
            };
            if (id != null) product.Id = id.Value;
            return product;

        }

        public void Extract(Product p)
        {
            Id = p.Id;
            Name ??= p.Name;
            Code ??= p.Code;
            Category = p.Category;
            Price = p.Price;
            TechDetail ??= p.TechDetail;
            Info ??= p.Info;
            DateUpdate = p.DateUpdate;
            images ??= p.ProductImages.Select(i => i.Url).ToHashSet();
        }
    }
}
