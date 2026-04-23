using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Customer? Customer { get; set; }
        public virtual Seller? Seller { get; set; }
    }
}
