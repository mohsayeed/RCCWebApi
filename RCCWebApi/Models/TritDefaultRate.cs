﻿using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritDefaultRate
    {
        public int DefaultRateId { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal? Rate { get; set; }
    }
}