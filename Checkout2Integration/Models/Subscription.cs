using System;

namespace Checkout.Integration.Models
{
    public class Subscription
    {
        public string MerchantCode { get; set; }
        public string SubscriptionReference { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool RecurringEnabled { get; set; }
        public bool SubscriptionEnabled { get; set; }
        public Product Product { get; set; }
        public Customer EndUser { get; set; }
        public string SKU { get; set; }
        public bool ReceiveNotifications { get; set; }
        public bool Lifetime { get; set; }
        public string PartnerCode { get; set; }
        public string IdAffiliate { get; set; }
        public string AvangateCustomerReference { get; set; }
        public string ExternalCustomerReference { get; set; }
        public bool TestSubscription { get; set; }
        public bool IsTrial { get; set; }
        public string Status { get; set; }
        public SuscriptionOrder LatestSubscriptionOrder { get; set; }
    }
}
