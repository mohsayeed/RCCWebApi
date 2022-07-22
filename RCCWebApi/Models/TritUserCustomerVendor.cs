using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritUserCustomerVendor
    {
        public TritUserCustomerVendor()
        {
            TritUsers = new HashSet<TritUser>();
        }

        public string UserCustomerVendorCode { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<TritUser> TritUsers { get; set; }
    }
}
