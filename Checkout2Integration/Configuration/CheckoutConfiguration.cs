namespace Checkout.Integration.Configuration
{
    public class CheckoutConfiguration
    {
        public string ApiEndpoint { get; set; }

        public CheckoutCredentials CheckoutCredentials { get; set; }

        public CheckoutConfiguration(){}

        public CheckoutConfiguration(string apiEndpoint, CheckoutCredentials checkoutCredentials)
        {
            ApiEndpoint = apiEndpoint;
            CheckoutCredentials = checkoutCredentials;
        }
    }
}
