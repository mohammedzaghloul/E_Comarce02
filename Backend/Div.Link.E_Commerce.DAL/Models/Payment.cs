using Div.Link.E_Commerce.DAL.Helper;
using Div.Link.E_Commerce.DAL.Models.BaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Div.Link.E_Commerce.DAL.Models
{
    public class Payment : BaseEntity
    {
        public DateTime PaidAt { get; set; } = DateTime.UtcNow;

        public decimal Amount { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;

        public PaymentMode PaymentMode { get; set; }

        public string? TransactionId { get; set; }

        public PaymentStatus Status { get; set; }
    }
}
