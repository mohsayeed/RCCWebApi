using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritSmsRecipient
    {
        public int SmsRecipientId { get; set; }
        public string SmsMessageId { get; set; } = null!;
        public string SmsStatusId { get; set; } = null!;
        public int UserId { get; set; }
        public DateTime SaleDate { get; set; }
        public string BillNumber { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? SpId { get; set; }
    }
}
