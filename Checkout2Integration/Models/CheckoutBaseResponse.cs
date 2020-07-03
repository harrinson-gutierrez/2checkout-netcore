
using System.Net;

namespace Checkout.Integration.Models
{
    public class CheckoutBaseResponse<T>
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public string ReasonPhrase { get; set; }

        public T Data { get; set; }

        public CheckoutBaseResponse() { }
    }
}
