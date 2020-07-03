namespace Checkout.Integration.Models
{
    public class PricingConfiguration
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public bool UseOriginalPrices { get; set; }
        public string PricingSchema { get; set; }
        public string PriceType { get; set; }
        public string DefaultCurrency { get; set; }
        public Prices Prices { get; set; }
    }
}
