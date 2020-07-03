using Checkout.Integration.Client;
using Checkout.Integration.Configuration;
using Checkout.Integration.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Checkout.Integration.Test
{
    public class CustomerUnitTest
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
        public async Task CreateCustomerAsync()
        {
            try
            {
                var response = await CheckoutApiClient.CreateCustomerAsync(new Customer()
                {
                    ExternalCustomerReference = "9397b8a8-bdb0-4ba6-80e9-1b31eb517f8b",
                    FirstName = "XX",
                    LastName = "xx",
                    Company = "",
                    FiscalCode = "",
                    Address1 = "cll ",
                    Address2 = "cll ",
                    City = "London",
                    State = "London",
                    Zip = "WC1A1AH",
                    CountryCode = "gb",
                    Phone = "265897456",
                    Fax = "",
                    Email = "test4@2checkout.com",
                    ExistingCards = new List<Card>(),
                    Enabled = false,
                    Trial = false,
                    Language = "GB",
                    CustomerReference = Guid.NewGuid().ToString()
                });

                Console.WriteLine("Create customer " + JsonConvert.SerializeObject(response, Formatting.Indented));
            }
            catch(CheckoutBaseException ex)
            {
                Console.WriteLine("Customer Error " + JsonConvert.SerializeObject(ex, Formatting.Indented));
            }
        }

        [Test]
        public async Task GetCustomerByCReferenceAsync()
        {
            var response = await CheckoutApiClient.GetCustomerByCReference("12345");

            Console.WriteLine("Customer detail " + JsonConvert.SerializeObject(response, Formatting.Indented));

            Assert.Pass();
        }
    }
}
