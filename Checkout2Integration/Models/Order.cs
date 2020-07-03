using System;

namespace Checkout.Integration.Models
{
    public class Order
    {
        public string AdditionalFields { get; set; }
        public int AffiliateCommission { get; set; }
        public Affiliate Affiliate { get; set; }
        public string ApproveStatus { get; set; }
        public float AvangateCommission { get; set; }
        public BillingDetails BillingDetails { get; set; }
        public string Currency { get; set; }
        public DeliveryDetails DeliveryDetails { get; set; }
        public float Discount { get; set; }
        public string ExternalReference { get; set; }
        public string ExtraDiscount { get; set; }
        public string ExtraMargin { get; set; }
        public string ExtraMarginPercent { get; set; }
        public string FinishDate { get; set; }
        public string GiftDetails { get; set; }
        public float GrossDiscountedPrice { get; set; }
        public float GrossPrice { get; set; }
        public bool HasShipping { get; set; }
    }
}
