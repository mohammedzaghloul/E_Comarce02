using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; } = null!;
        public ApplicationUser ApplicationUser { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
        public int AddressId { get; set; }
        public Address Address { get; set; } = null!;


    }
}
