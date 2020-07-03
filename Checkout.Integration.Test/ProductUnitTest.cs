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
    public class ProductUnitTests
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
        public async Task GetProductsAsync()
        {
            var response = await CheckoutApiClient.GetProductsAsync();

            Console.WriteLine("Products " + JsonConvert.SerializeObject(response, Formatting.Indented));

            Assert.Pass();
        }

        [Test]
        public async Task CreateProductAsync()
        {
            var response = await CheckoutApiClient.CreateProductAsync(new Product()
            {
                ProductCode = "Producto_prueba",
                ProductType = "REGULAR",
                ProductName = "Prueba 1",
                ProductVersion = 1,
                Tangible = false,
                LongDescription = "Producto 1",
                ShortDescription = "Producto 1",
                ProductCategory = "",
                PricingConfigurations = new List<PricingConfiguration>()
                {
                    new PricingConfiguration()
                    {
                        Name = "Product 1 configuration",
                        Code = "Product1",
                        UseOriginalPrices = false,
                        PricingSchema = "DYNAMIC",
                        PriceType = "GROSS",
                        DefaultCurrency = "USD",
                        Prices = new Prices()
                        {
                            Regular = new List<Price>()
                            {
                                new Price()
                                {
                                    Amount = 20,
                                    Currency = "USD",
                                    MinQuantity = 1,
                                    MaxQuantity = 9999
                                }
                            }
                        }
                    }
                }
            });

            Console.WriteLine("Products " + JsonConvert.SerializeObject(response, Formatting.Indented));

            Assert.Pass();
        }

        [Test]
        public async Task EnabledProductAsync()
        {
            var response = await CheckoutApiClient.EnabledProductAsync("Producto_prueba");

            Console.WriteLine("Products " + JsonConvert.SerializeObject(response, Formatting.Indented));

            Assert.Pass();
        }
    }
}