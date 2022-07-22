using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritCommonErrorLog
    {
        public int CommonErrorLogId { get; set; }
        public string UserName { get; set; } = null!;
        public string? ProcedureName { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
