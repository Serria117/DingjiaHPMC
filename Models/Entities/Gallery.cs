using System;
using System.Collections.Generic;

namespace DingjiaHpmc.Models.Entities
{
    public partial class Gallery
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public int? Type { get; set; }

        public virtual GalleryType? TypeNavigation { get; set; }
    }
}
