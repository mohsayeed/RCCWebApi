using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritRole
    {
        public TritRole()
        {
            TritUserRoles = new HashSet<TritUserRole>();
        }

        public int RoleId { get; set; }
        public string RoleDesc { get; set; } = null!;

        public virtual ICollection<TritUserRole> TritUserRoles { get; set; }
    }
}
