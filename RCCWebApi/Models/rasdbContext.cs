using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RCCWebApi.Models
{
    public partial class rasdbContext : DbContext
    {
        public rasdbContext()
        {
        }

        public rasdbContext(DbContextOptions<rasdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TritAccount> TritAccounts { get; set; } = null!;
        public virtual DbSet<TritCommonErrorLog> TritCommonErrorLogs { get; set; } = null!;
        public virtual DbSet<TritDailyRate> TritDailyRates { get; set; } = null!;
        public virtual DbSet<TritDefaultRate> TritDefaultRates { get; set; } = null!;
        public virtual DbSet<TritLogin> TritLogins { get; set; } = null!;
        public virtual DbSet<TritMobileLogin> TritMobileLogins { get; set; } = null!;
        public virtual DbSet<TritOrder> TritOrders { get; set; } = null!;
        public virtual DbSet<TritPurchase> TritPurchases { get; set; } = null!;
        public virtual DbSet<TritPurchasePayment> TritPurchasePayments { get; set; } = null!;
        public virtual DbSet<TritRole> TritRoles { get; set; } = null!;
        public virtual DbSet<TritSale> TritSales { get; set; } = null!;
        public virtual DbSet<TritSalesPayment> TritSalesPayments { get; set; } = null!;
        public virtual DbSet<TritSmsMessage> TritSmsMessages { get; set; } = null!;
        public virtual DbSet<TritSmsRecipient> TritSmsRecipients { get; set; } = null!;
        public virtual DbSet<TritSmsStatus> TritSmsStatuses { get; set; } = null!;
        public virtual DbSet<TritUser> TritUsers { get; set; } = null!;
        public virtual DbSet<TritUserCustomerVendor> TritUserCustomerVendors { get; set; } = null!;
        public virtual DbSet<TritUserRole> TritUserRoles { get; set; } = null!;
        public virtual DbSet<TritWalkin> TritWalkins { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TritAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__TRIT_ACC__05B22F60E9A245A6");

                entity.ToTable("TRIT_ACCOUNT");

                entity.Property(e => e.AccountId).HasColumnName("ACCOUNT_ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACCOUNT_NUMBER");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BANK_NAME");

                entity.Property(e => e.Branch)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH");

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.District)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DISTRICT");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FULL_NAME");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IFSC_CODE");

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TritAccountUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_ACCO__UPDAT__0C85DE4D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TritAccountUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_ACCO__USER___0D7A0286");
            });

            modelBuilder.Entity<TritCommonErrorLog>(entity =>
            {
                entity.HasKey(e => e.CommonErrorLogId)
                    .HasName("PK__TRIT_COM__37DF0A4F85703DEE");

                entity.ToTable("TRIT_COMMON_ERROR_LOG");

                entity.Property(e => e.CommonErrorLogId).HasColumnName("COMMON_ERROR_LOG_ID");

                entity.Property(e => e.ErrorMessage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ERROR_MESSAGE");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("MODIFIED_DATE");

                entity.Property(e => e.ProcedureName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PROCEDURE_NAME");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");
            });

            modelBuilder.Entity<TritDailyRate>(entity =>
            {
                entity.HasKey(e => e.DailyRateId)
                    .HasName("PK__TRIT_DAI__413D5BCE7697C7E0");

                entity.ToTable("TRIT_DAILY_RATES");

                entity.Property(e => e.DailyRateId).HasColumnName("DAILY_RATE_ID");

                entity.Property(e => e.CutOffTime).HasColumnName("CUT_OFF_TIME");

                entity.Property(e => e.DailyDate)
                    .HasColumnType("date")
                    .HasColumnName("DAILY_DATE");

                entity.Property(e => e.LiveRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("LIVE_RATE");

                entity.Property(e => e.SkinlessRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("SKINLESS_RATE");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.WithSkinRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("WITH_SKIN_RATE");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TritDailyRates)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__TRIT_DAIL__UPDAT__3B40CD36");
            });

            modelBuilder.Entity<TritDefaultRate>(entity =>
            {
                entity.HasKey(e => e.DefaultRateId)
                    .HasName("PK__TRIT_DEF__ECB5162978EEDF86");

                entity.ToTable("TRIT_DEFAULT_RATE");

                entity.Property(e => e.DefaultRateId).HasColumnName("DEFAULT_RATE_ID");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RATE");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("date")
                    .HasColumnName("SALE_DATE");
            });

            modelBuilder.Entity<TritLogin>(entity =>
            {
                entity.HasKey(e => e.LoginId)
                    .HasName("PK__TRIT_LOG__476A024D658C49D3");

                entity.ToTable("TRIT_LOGIN");

                entity.Property(e => e.LoginId).HasColumnName("LOGIN_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TritLoginUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__TRIT_LOGI__UPDAT__0E6E26BF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TritLoginUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_LOGI__USER___0F624AF8");
            });

            modelBuilder.Entity<TritMobileLogin>(entity =>
            {
                entity.HasKey(e => e.MobileLoginId)
                    .HasName("PK__TRIT_MOB__255122C228F86025");

                entity.ToTable("TRIT_MOBILE_LOGIN");

                entity.Property(e => e.MobileLoginId).HasColumnName("MOBILE_LOGIN_ID");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.PasswordReset)
                    .HasColumnName("PASSWORD_RESET")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TritMobileLoginUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__TRIT_MOBI__UPDAT__3493CFA7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TritMobileLoginUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_MOBI__USER___3587F3E0");
            });

            modelBuilder.Entity<TritOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__TRIT_ORD__460A9464A9110AF8");

                entity.ToTable("TRIT_ORDER");

                entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

                entity.Property(e => e.OrderCages)
                    .HasColumnName("ORDER_CAGES")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ORDER_DATE");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");
            });

            modelBuilder.Entity<TritPurchase>(entity =>
            {
                entity.HasKey(e => e.PurchaseId)
                    .HasName("PK__TRIT_PUR__AF7B9D5417E84B65");

                entity.ToTable("TRIT_PURCHASE");

                entity.Property(e => e.PurchaseId).HasColumnName("PURCHASE_ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PURCHASE_DATE");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RATE")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("WEIGHT")
                    .HasDefaultValueSql("((0.000))");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TritPurchaseUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_PURC__UPDAT__10566F31");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TritPurchaseUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_PURC__USER___114A936A");
            });

            modelBuilder.Entity<TritPurchasePayment>(entity =>
            {
                entity.HasKey(e => e.PurchasePaymentId)
                    .HasName("PK__TRIT_PUR__6212CEEC0AF37C19");

                entity.ToTable("TRIT_PURCHASE_PAYMENT");

                entity.Property(e => e.PurchasePaymentId).HasColumnName("PURCHASE_PAYMENT_ID");

                entity.Property(e => e.AmountPaid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT_PAID")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.DiscountAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DISCOUNT_AMT")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PurchaseDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PURCHASE_DATE");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TritPurchasePaymentUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_PURC__UPDAT__123EB7A3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TritPurchasePaymentUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_PURC__USER___1332DBDC");
            });

            modelBuilder.Entity<TritRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__TRIT_ROL__5AC4D22246468B31");

                entity.ToTable("TRIT_ROLE");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_DESC");
            });

            modelBuilder.Entity<TritSale>(entity =>
            {
                entity.HasKey(e => e.SalesId)
                    .HasName("PK__TRIT_SAL__BAE7944505B6E417");

                entity.ToTable("TRIT_SALES");

                entity.Property(e => e.SalesId).HasColumnName("SALES_ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BILL_NUMBER")
                    .HasDefaultValueSql("('B1')");

                entity.Property(e => e.DressingAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DRESSING_AMOUNT");

                entity.Property(e => e.EmptyCage)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("EMPTY_CAGE")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.FullCage)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("FULL_CAGE")
                    .HasDefaultValueSql("((0.000))");

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("RATE")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SALE_DATE");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15, 3)")
                    .HasColumnName("WEIGHT")
                    .HasDefaultValueSql("((0.000))");
            });

            modelBuilder.Entity<TritSalesPayment>(entity =>
            {
                entity.HasKey(e => e.SalesPaymentId)
                    .HasName("PK__TRIT_SAL__4D769D041971A5A2");

                entity.ToTable("TRIT_SALES_PAYMENT");

                entity.Property(e => e.SalesPaymentId).HasColumnName("SALES_PAYMENT_ID");

                entity.Property(e => e.AmountPaid)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("AMOUNT_PAID")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.DiscountAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DISCOUNT_AMT")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SalesDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SALES_DATE");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.TritSalesPaymentUpdatedByNavigations)
                    .HasForeignKey(d => d.UpdatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_SALE__UPDAT__14270015");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TritSalesPaymentUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_SALE__USER___151B244E");
            });

            modelBuilder.Entity<TritSmsMessage>(entity =>
            {
                entity.HasKey(e => e.SmsMessageId)
                    .HasName("PK__TRIT_SMS__446FE4F10EA90CEC");

                entity.ToTable("TRIT_SMS_Message");

                entity.Property(e => e.SmsMessageId).HasColumnName("SMS_Message_ID");

                entity.Property(e => e.MessageBody)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Message_body");

                entity.Property(e => e.MessageTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Message_Title");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TritSmsRecipient>(entity =>
            {
                entity.HasKey(e => e.SmsRecipientId)
                    .HasName("PK__TRIT_SMS__6CA536D00B01B0B7");

                entity.ToTable("TRIT_SMS_Recipient");

                entity.Property(e => e.SmsRecipientId).HasColumnName("SMS_Recipient_ID");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("Bill_number");

                entity.Property(e => e.CreatedBy).HasColumnName("created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.SaleDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sale_date");

                entity.Property(e => e.SmsMessageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMS_Message_Id");

                entity.Property(e => e.SmsStatusId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SMS_Status_Id");

                entity.Property(e => e.SpId).HasColumnName("sp_id");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<TritSmsStatus>(entity =>
            {
                entity.HasKey(e => e.SmsStatusId)
                    .HasName("PK__TRIT_SMS__53AD9B68D30A3B3F");

                entity.ToTable("TRIT_SMS_Status");

                entity.Property(e => e.SmsStatusId).HasColumnName("SMS_Status_ID");

                entity.Property(e => e.SmsStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMS_Status");
            });

            modelBuilder.Entity<TritUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__TRIT_USE__F3BEEBFFDCC54F9E");

                entity.ToTable("TRIT_USER");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_2");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.InitialDueBalance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("INITIAL_DUE_BALANCE");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IS_ACTIVE")
                    .IsFixedLength();

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DT");

                entity.Property(e => e.UserCustomerVendorCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("USER_CUSTOMER_VENDOR_CODE");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.InverseUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__TRIT_USER__UPDAT__160F4887");

                entity.HasOne(d => d.UserCustomerVendorCodeNavigation)
                    .WithMany(p => p.TritUsers)
                    .HasForeignKey(d => d.UserCustomerVendorCode)
                    .HasConstraintName("FK__TRIT_USER__USER___17036CC0");
            });

            modelBuilder.Entity<TritUserCustomerVendor>(entity =>
            {
                entity.HasKey(e => e.UserCustomerVendorCode)
                    .HasName("PK__TRIT_USE__CCE2E5899EB78F42");

                entity.ToTable("TRIT_USER_CUSTOMER_VENDOR");

                entity.Property(e => e.UserCustomerVendorCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("USER_CUSTOMER_VENDOR_CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<TritUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .HasName("PK__TRIT_USE__A50F1D20837AC866");

                entity.ToTable("TRIT_USER_ROLE");

                entity.Property(e => e.UserRoleId).HasColumnName("USER_ROLE_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.CreatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CREATED_DT");

                entity.Property(e => e.RoleId).HasColumnName("ROLE_ID");

                entity.Property(e => e.UserId).HasColumnName("USER_ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TritUserRoleCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_USER__CREAT__17F790F9");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TritUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_USER__ROLE___18EBB532");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TritUserRoleUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRIT_USER__USER___19DFD96B");
            });

            modelBuilder.Entity<TritWalkin>(entity =>
            {
                entity.HasKey(e => e.WalkinsId)
                    .HasName("PK__TRIT_WAL__2CD9FEF3E0450596");

                entity.ToTable("TRIT_WALKINS");

                entity.Property(e => e.WalkinsId).HasColumnName("WALKINS_ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.DueAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DUE_AMOUNT");

                entity.Property(e => e.DueDate)
                    .HasColumnType("date")
                    .HasColumnName("DUE_DATE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.UpdatedBy).HasColumnName("UPDATED_BY");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("UPDATED_DATE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
