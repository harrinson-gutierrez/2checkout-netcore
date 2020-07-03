using Checkout.Integration.Configuration;
using Checkout.Integration.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Integration.Client
{
    public partial class CheckoutApiClient
    {
        protected string ApiEndpoint;

        protected string MerchantCode;

        protected string MerchantSecret;

        protected AuthenticatorHelper Authenticator;

        protected HttpClient Client { get; private set; }

        public CheckoutApiClient(CheckoutConfiguration checkoutConfiguration)
        {
            ApiEndpoint = checkoutConfiguration.ApiEndpoint;
            MerchantCode = checkoutConfiguration.CheckoutCredentials.MerchantCode;
            MerchantSecret = checkoutConfiguration.CheckoutCredentials.MerchantSecret;
            this.Authenticator = new AuthenticatorHelper(MerchantCode, MerchantSecret);
            InitialInitizeClientCheckout();
        }


        protected void InitialInitizeClientCheckout()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(ApiEndpoint);
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        protected void AddTokenSecurityClient()
        {
            Client.DefaultRequestHeaders.Remove("X-Avangate-Authentication");
            Client.DefaultRequestHeaders.TryAddWithoutValidation("X-Avangate-Authentication", this.Authenticator.GetAuthToken());
        }

        public async Task<CheckoutBaseResponse<Response>> Invoke<Response>(HttpMethod httpMethod, string path, string body)
        {
            AddTokenSecurityClient();
            HttpResponseMessage httpResponse = null;

            switch (httpMethod.ToString().ToUpper())
            {
                case "GET":
                    {
                        Console.WriteLine(path);
                        httpResponse = await Client.GetAsync(path);
                        break;
                    }
                case "POST":
                    {
                        HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");

                        httpResponse = await Client.PostAsync(path, content);
                        break;
                    }
                case "PUT":
                    {
                        HttpContent content = new StringContent(body, Encoding.UTF8, "application/json");

                        httpResponse = await Client.PutAsync(path, content);
                        break;
                    }
                case "DELETE":
                    {
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, path)
                        {
                            Content = new StringContent(body, Encoding.UTF8, "application/json")
                        };
                        httpResponse = await Client.SendAsync(request);
                        break;
                    }
            }


            return await HandleResponse<Response>(httpResponse);
        }

        protected async Task<CheckoutBaseResponse<Response>> HandleResponse<Response>(HttpResponseMessage httpResponseMessage)
        {
            CheckoutBaseResponse<Response> checkoutBaseResponse = new CheckoutBaseResponse<Response>
            {
                HttpStatusCode = httpResponseMessage.StatusCode,
                ReasonPhrase = httpResponseMessage.ReasonPhrase
            };

            if (httpResponseMessage.StatusCode.Equals(HttpStatusCode.OK))
            {
                checkoutBaseResponse.Data = JsonConvert.DeserializeObject<Response>(await httpResponseMessage.Content.ReadAsStringAsync());
            }
            else if (httpResponseMessage.StatusCode.Equals(HttpStatusCode.BadRequest))
            {
                throw new CheckoutBadRequestException()
                {
                    CheckoutException = JsonConvert.DeserializeObject<CheckoutExceptionResponse>(await httpResponseMessage.Content.ReadAsStringAsync())
                };
            }

            return checkoutBaseResponse;
        }
    }
}
