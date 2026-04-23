using Div.Link.E_Commerce.DAL.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime DateOfPayment { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; } = 0;
        public Customer Customer { get; set; } = null!;
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public PaymentMode PaymentMode { get; set; }

    }
}
