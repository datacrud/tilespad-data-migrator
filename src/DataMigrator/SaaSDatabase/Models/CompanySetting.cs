using System;
using System.Collections.Generic;

namespace SaaSDatabase.Models
{
    public partial class CompanySetting
    {
        public string Id { get; set; }
        public string DefineLowStockQuantity { get; set; }
        public string PoweredBy { get; set; }
        public bool HasYearlyHostingCharge { get; set; }
        public double YearlyHostingChargeAmount { get; set; }
        public DateTime? HostingValidTill { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
        public string DeletedBy { get; set; }
        public string TenantId { get; set; }
        public string CompanyId { get; set; }
        public string EmailSenderDisplayName { get; set; }
        public string DeviceInfo { get; set; }
        public string IpAddress { get; set; }
        public double SaleVatPercentage { get; set; }
        public string TinNumber { get; set; }
        public string BinNumber { get; set; }
        public int? Order { get; set; }
        public string CustomerInvoiceTermsAndConditions { get; set; }
        public bool IsUseDefaultSettings { get; set; }
        public string NotificationSenderEmail { get; set; }
        public bool IsEnableEmailNotification { get; set; }
        public bool IsSendEmailToAdminForTransaction { get; set; }
        public bool IsSendEmailToCustomerForOrders { get; set; }
        public bool IsSendEmailToCustomerForDelivery { get; set; }
        public bool IsSendEmailToCustomerForTransaction { get; set; }
        public bool IsEnableSmsNotification { get; set; }
        public bool IsSendSmsToAdminForTransaction { get; set; }
        public bool IsSendSmsToCustomerForOrders { get; set; }
        public bool IsSendSmsToCustomerForDelivery { get; set; }
        public bool IsSendSmsToCustomerForTransaction { get; set; }
        public bool EnableStockLessFeatures { get; set; }
        public string OriginalPk { get; set; }

        public virtual Company Company { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers DeletedByNavigation { get; set; }
        public virtual AspNetUsers ModifiedByNavigation { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
