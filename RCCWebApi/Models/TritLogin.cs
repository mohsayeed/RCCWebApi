﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritLogin
    {
        public int LoginId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }

        public virtual TritUser UpdatedByNavigation { get; set; }
        public virtual TritUser User { get; set; }
    }
}