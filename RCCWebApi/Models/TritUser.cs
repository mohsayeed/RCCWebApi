using System;
using System.Collections.Generic;

namespace RCCWebApi.Models
{
    public partial class TritUser
    {
        public TritUser()
        {
            InverseUpdatedByNavigation = new HashSet<TritUser>();
            TritAccountUpdatedByNavigations = new HashSet<TritAccount>();
            TritAccountUsers = new HashSet<TritAccount>();
            TritDailyRates = new HashSet<TritDailyRate>();
            TritLoginUpdatedByNavigations = new HashSet<TritLogin>();
            TritLoginUsers = new HashSet<TritLogin>();
            TritMobileLoginUpdatedByNavigations = new HashSet<TritMobileLogin>();
            TritMobileLoginUsers = new HashSet<TritMobileLogin>();
            TritPurchasePaymentUpdatedByNavigations = new HashSet<TritPurchasePayment>();
            TritPurchasePaymentUsers = new HashSet<TritPurchasePayment>();
            TritPurchaseUpdatedByNavigations = new HashSet<TritPurchase>();
            TritPurchaseUsers = new HashSet<TritPurchase>();
            TritSalesPaymentUpdatedByNavigations = new HashSet<TritSalesPayment>();
            TritSalesPaymentUsers = new HashSet<TritSalesPayment>();
            TritUserRoleCreatedByNavigations = new HashSet<TritUserRole>();
            TritUserRoleUsers = new HashSet<TritUserRole>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? IsActive { get; set; }
        public string? UserCustomerVendorCode { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public decimal InitialDueBalance { get; set; }

        public virtual TritUser? UpdatedByNavigation { get; set; }
        public virtual TritUserCustomerVendor? UserCustomerVendorCodeNavigation { get; set; }
        public virtual ICollection<TritUser> InverseUpdatedByNavigation { get; set; }
        public virtual ICollection<TritAccount> TritAccountUpdatedByNavigations { get; set; }
        public virtual ICollection<TritAccount> TritAccountUsers { get; set; }
        public virtual ICollection<TritDailyRate> TritDailyRates { get; set; }
        public virtual ICollection<TritLogin> TritLoginUpdatedByNavigations { get; set; }
        public virtual ICollection<TritLogin> TritLoginUsers { get; set; }
        public virtual ICollection<TritMobileLogin> TritMobileLoginUpdatedByNavigations { get; set; }
        public virtual ICollection<TritMobileLogin> TritMobileLoginUsers { get; set; }
        public virtual ICollection<TritPurchasePayment> TritPurchasePaymentUpdatedByNavigations { get; set; }
        public virtual ICollection<TritPurchasePayment> TritPurchasePaymentUsers { get; set; }
        public virtual ICollection<TritPurchase> TritPurchaseUpdatedByNavigations { get; set; }
        public virtual ICollection<TritPurchase> TritPurchaseUsers { get; set; }
        public virtual ICollection<TritSalesPayment> TritSalesPaymentUpdatedByNavigations { get; set; }
        public virtual ICollection<TritSalesPayment> TritSalesPaymentUsers { get; set; }
        public virtual ICollection<TritUserRole> TritUserRoleCreatedByNavigations { get; set; }
        public virtual ICollection<TritUserRole> TritUserRoleUsers { get; set; }
    }
}
