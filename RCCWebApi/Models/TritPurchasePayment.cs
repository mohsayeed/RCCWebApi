﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritPurchasePayment
    {
        public int PurchasePaymentId { get; set; }
        public int UserId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal DiscountAmt { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        public string Comments { get; set; }

        public virtual TritUser UpdatedByNavigation { get; set; }
        public virtual TritUser User { get; set; }
    }
}