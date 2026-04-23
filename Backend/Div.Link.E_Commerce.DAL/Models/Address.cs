
using System;
using System.Collections.Generic;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Address : BaseEntity
    {
        public int Apart_no { get; set; }
        public string ApartName { get; set; }
        public string StreetName { get; set; } 

        public string City { get; set; } 
        public string State { get; set; } = string.Empty;
        public int PinCode { get; set; }
        public int CustomerId { get; set; }
    }
}
