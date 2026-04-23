using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Add custom properties here, e.g.
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Seller? Seller { get; set; }
    }
}
