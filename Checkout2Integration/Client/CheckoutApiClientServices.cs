using Checkout.Integration.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Checkout.Integration.Client
{
    public partial class CheckoutApiClient
    {
        public async Task<CheckoutBaseResponse<PaginationWrapper<Product>>> GetProductsAsync()
        {
            return await Invoke<PaginationWrapper<Product>>(HttpMethod.Get, "products/", "");
        }

        public async Task<CheckoutBaseResponse<Product>> GetProductByProductCodeAsync(string productCode)
        {
            return await Invoke<Product>(HttpMethod.Get, "products/" + productCode + "/", "");
        }

        public async Task<CheckoutBaseResponse<Product>> CreateProductAsync(Product product)
        {
            return await Invoke<Product>(HttpMethod.Post, "products/", JsonConvert.SerializeObject(product));
        }

        public async Task<CheckoutBaseResponse<string>> UpdateProductAsync(string productCode, Product product)
        {
            return await Invoke<string>(HttpMethod.Put, "products/" + productCode + "/", JsonConvert.SerializeObject(product));
        }

        public async Task<CheckoutBaseResponse<bool>> EnabledProductAsync(string productCode)
        {
            return await Invoke<bool>(HttpMethod.Post, "products/" + productCode + "/", "");
        }

        public async Task<CheckoutBaseResponse<bool>> DisabledProductAsync(string productCode)
        {
            return await Invoke<bool>(HttpMethod.Delete, "products/" + productCode + "/", "");
        }

        public async Task<CheckoutBaseResponse<List<ProductGroup>>> GetProductGroupsAsync()
        {
            return await Invoke<List<ProductGroup>>(HttpMethod.Get, "productgroups/", "");
        }

        public async Task<CheckoutBaseResponse<string>> CreateProductGroupAsync(ProductGroup productGroup)
        {
            return await Invoke<string>(HttpMethod.Post, "productgroups/", JsonConvert.SerializeObject(productGroup));
        }

        public async Task<CheckoutBaseResponse<ProductGroup>> GetProductGroupByCodeAsync(string productGroupCode)
        {
            return await Invoke<ProductGroup>(HttpMethod.Get, "productgroups/" + productGroupCode + "/", "");
        }

        public async Task<CheckoutBaseResponse<bool>> AsssignProductToGroupAsync(string productCode, string productGroupCode)
        {
            return await Invoke<bool>(HttpMethod.Post, "products/" + productCode + "/productgroups/" + productGroupCode + "/", "");
        }
            
        public async Task<CheckoutBaseResponse<bool>> UnasssignProductToGroupAsync(string productCode, string productGroupCode)
        {
            return await Invoke<bool>(HttpMethod.Delete, "products/" + productCode + "/productgroups/" + productGroupCode + "/", "");
        }

        public async Task<CheckoutBaseResponse<PaginationWrapper<Subscription>>> GetSubscriptionsAsync()
        {
            return await Invoke<PaginationWrapper<Subscription>>(HttpMethod.Get, "subscriptions/", "");
        }

        public async Task<CheckoutBaseResponse<string>> CreateCustomerAsync(Customer customer)
        {
            return await Invoke<string>(HttpMethod.Post, "customers/", JsonConvert.SerializeObject(customer));
        }

        public async Task<CheckoutBaseResponse<Customer>> GetCustomerByCReference(string cReference)
        {
            return await Invoke<Customer>(HttpMethod.Get, "customers/" + cReference + "/", "");
        }

        public async Task<CheckoutBaseResponse<PaginationWrapper<Order>>> GetOrdersAsync(NameValueCollection filter)
        {
            var query = String.Join("&", filter.AllKeys.Select(a => a + "=" + HttpUtility.UrlEncode(filter[a])));
            var endpoint = filter?.Count > 0 ? "orders/?" + query : "orders/";

            return await Invoke<PaginationWrapper<Order>>(HttpMethod.Get, endpoint, "");
        }
        public async Task<CheckoutBaseResponse<Order>> GetOrderByReferenceAsync(string orderReference)
        {
            return await Invoke<Order>(HttpMethod.Get, "orders/" + orderReference + "/", "");
        }
    }
}
