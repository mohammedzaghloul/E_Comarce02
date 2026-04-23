
using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Address : BaseEntity
    {
        public int Apart_no { get; set; }
        public string ApartName { get; set; }=null!;
        public string StreetName { get; set; } =null!;

        public string City { get; set; } =null!;
        public string? State { get; set; } 
        public int PinCode { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
