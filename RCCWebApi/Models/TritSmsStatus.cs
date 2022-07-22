using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritSmsStatus
    {
        public int SmsStatusId { get; set; }
        public string SmsStatus { get; set; } = null!;
    }
}
