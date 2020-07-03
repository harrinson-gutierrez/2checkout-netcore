using System.Collections.Generic;

namespace Checkout.Integration.Models
{
    public class Product
    {
        public int AvangateId { get; set; }

        public string ProductCode { get; set; }

        public string ExternalReference { get; set; }

        public string ProductType { get; set; }

        public string ProductName { get; set; }

        public int ProductVersion { get; set; }

        public bool Tangible { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string ProductCategory { get; set; }

        public bool Enabled { get; set; }

        public List<PricingConfiguration> PricingConfigurations { get; set; }

        public string Fulfillment { get; set; }

        public SubscriptionInformation SubscriptionInformation { get; set; }
    }
}
