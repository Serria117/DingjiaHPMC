using Microsoft.AspNetCore.Identity;

namespace DingjiaHpmc.Areas.Identity.Data
{
    public class AppRole : IdentityRole<int>
    {
        public string? Description { get; set; }
    }
}
