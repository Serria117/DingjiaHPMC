using DingjiaHpmc.Models.DataTransfer;
using DingjiaHpmc.Models.Entities;

namespace DingjiaHpmc.Models.ViewModels
{
    public class HomeViewModel
    {
        public List<ProductDto> ProductList { get; set; } = new List<ProductDto>();
        public List<Gallery> GalleryList { get; set; } = new List<Gallery>();
        public List<Content> ContentList { get; set; } = new List<Content>();
        public Feedback CustomerFeedback { get; set; } = new Feedback();
    }
}
