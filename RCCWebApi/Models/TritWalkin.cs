using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritWalkin
    {
        public int WalkinsId { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public DateTime? DueDate { get; set; }
        public decimal DueAmount { get; set; }
        public string? Comments { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
