using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritUserRole
    {
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }

        public virtual TritUser CreatedByNavigation { get; set; } = null!;
        public virtual TritRole Role { get; set; } = null!;
        public virtual TritUser User { get; set; } = null!;
    }
}
