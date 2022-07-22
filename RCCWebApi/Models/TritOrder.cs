using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritOrder
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int OrderCages { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
    }
}
