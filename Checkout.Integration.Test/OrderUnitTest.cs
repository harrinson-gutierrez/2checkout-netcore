using Checkout.Integration.Client;
using Checkout.Integration.Configuration;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace Checkout.Integration.Test
{
    public class OrderUnitTest
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
        public async Task GetOrdersAsync()
        {
            NameValueCollection nameValueCollection = new NameValueCollection();
            //nameValueCollection.Add("StartDate", "2020-01-01");
            nameValueCollection.Add("Status", "Unfinished");
            var response = await CheckoutApiClient.GetOrdersAsync(nameValueCollection);
            Console.WriteLine("Get orders " + JsonConvert.SerializeObject(response, Formatting.Indented));

            Assert.Pass();
        }

        [Test]
        public async Task GetOrderByReferenceAsync()
        {
            var response = await CheckoutApiClient.GetOrderByReferenceAsync("123416902");
            Console.WriteLine("Get orders by reference " + JsonConvert.SerializeObject(response, Formatting.Indented));

            Assert.Pass();
        }
    }
}
