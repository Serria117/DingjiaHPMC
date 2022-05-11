using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DingjiaHpmc.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser<int>
{
    public string FullName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty ;
}

