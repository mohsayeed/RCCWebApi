using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritPurchasePayment
    {
        public int PurchasePaymentId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal DiscountAmt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        public string? Comments { get; set; }

        public virtual TritUser UpdatedByNavigation { get; set; } = null!;
        public virtual TritUser User { get; set; } = null!;
    }
}
