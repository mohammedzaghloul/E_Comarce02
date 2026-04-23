using Div.Link.E_Commerce.DAL.Helper;
using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Review : BaseEntity
    {
        public string? Description { get; set; }
        public Rating Rating { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
