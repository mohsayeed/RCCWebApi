using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritMobileLogin
    {
        public int MobileLoginId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool? PasswordReset { get; set; }

        public virtual TritUser? UpdatedByNavigation { get; set; }
        public virtual TritUser User { get; set; } = null!;
    }
}
