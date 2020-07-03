namespace Checkout.Integration.Configuration
{
    public class CheckoutCredentials
    {
        public string MerchantCode { get; set; }

        public string MerchantSecret { get; set; }

        public CheckoutCredentials() { }

        public CheckoutCredentials(string merchantCode, string merchantSecret)
        {
            MerchantCode = merchantCode;
            MerchantSecret = merchantSecret;
        }
    }
}
