namespace Checkout.Integration.Models
{
    public class SubscriptionInformation
    {
        public string BundleRenewalManagement { get; set; }
        public int BillingCycle { get; set; }
        public string BillingCycleUnits { get; set; }
        public bool IsOneTimeFee { get; set; }
        public ContractPeriod ContractPeriod { get; set; }
        public int UsageBilling { get; set; }
        public GracePeriod GracePeriod {get; set;}
        public RenewalEmails RenewalEmails { get; set; }
    }
}
