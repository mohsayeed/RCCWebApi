using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritAccount
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string? BankName { get; set; }
        public string? IfscCode { get; set; }
        public string? AccountNumber { get; set; }
        public string? Branch { get; set; }
        public string? District { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }

        public virtual TritUser UpdatedByNavigation { get; set; } = null!;
        public virtual TritUser User { get; set; } = null!;
    }
}
