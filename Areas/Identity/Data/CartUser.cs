using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Cart.Areas.Identity.Data;

// Add profile data for application users by adding properties to the CartUser class
public class CartUser : IdentityUser
{
    public string Name { get; set; }
    public long PhoneNo { get; set; }
}

