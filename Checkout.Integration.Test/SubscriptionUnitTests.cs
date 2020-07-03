using Checkout.Integration.Client;
using Checkout.Integration.Configuration;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Checkout.Integration.Test
{
    public class SubscriptionUnitTests
    {
        CheckoutApiClient CheckoutApiClient;

        [SetUp]
        public void Setup()
        {
            CheckoutConfiguration checkoutConfiguration = new CheckoutConfiguration("https://api.2checkout.com/rest/6.0/",
                                                                 new CheckoutCredentials("XXXXX", "XXXXXX"));

            CheckoutApiClient = new CheckoutApiClient(checkoutConfiguration);
        }

        [Test]
        public async Task GetSubscriptionsAsync()
        {
            var response = await CheckoutApiClient.GetSubscriptionsAsync();

            Console.WriteLine("Subscriptions " + JsonConvert.SerializeObject(response, Formatting.Indented));

            Assert.Pass();
        }
    }
}
