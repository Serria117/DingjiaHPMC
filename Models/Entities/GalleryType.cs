using System;
using System.Collections.Generic;

namespace DingjiaHpmc.Models.Entities
{
    public partial class GalleryType
    {
        public GalleryType()
        {
            Galleries = new HashSet<Gallery>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }
    }
}
