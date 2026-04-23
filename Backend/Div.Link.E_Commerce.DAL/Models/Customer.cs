using Div.Link.E_Commerce.DAL.Models.BaseClass;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Customer : BaseEntity
    {
        public string ApplicationUserId { get; set; } = null!;
        public ApplicationUser ApplicationUser { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public ICollection<Cart> Carts { get; set; } = new HashSet<Cart>();
        public ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
