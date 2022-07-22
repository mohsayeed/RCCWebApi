﻿using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritSale
    {
        public int SalesId { get; set; }
        public int UserId { get; set; }
        public DateTime? SaleDate { get; set; }
        public decimal FullCage { get; set; }
        public decimal EmptyCage { get; set; }
        public decimal? Weight { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        public string BillNumber { get; set; } = null!;
        public decimal DressingAmount { get; set; }
    }
}