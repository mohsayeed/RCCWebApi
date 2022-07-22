using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritSmsMessage
    {
        public int SmsMessageId { get; set; }
        public string MessageTitle { get; set; } = null!;
        public string MessageBody { get; set; } = null!;
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
