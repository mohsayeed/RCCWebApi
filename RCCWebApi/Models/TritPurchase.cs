using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritPurchase
    {
        public int PurchaseId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal? Weight { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }

        public virtual TritUser UpdatedByNavigation { get; set; } = null!;
        public virtual TritUser User { get; set; } = null!;
    }
}
