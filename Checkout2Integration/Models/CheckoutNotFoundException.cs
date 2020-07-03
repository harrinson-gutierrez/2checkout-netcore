using System;
using System.Net;

namespace Checkout.Integration.Models
{
    public class CheckoutNotFoundException : CheckoutBaseException
    {

        public CheckoutNotFoundException(string reasonPhrase) : base(reasonPhrase)
        {
            StatusCode = HttpStatusCode.NotFound;
        }

        public CheckoutNotFoundException(HttpStatusCode statusCode, string reasonPhrase) : base(statusCode, reasonPhrase) { }

    }
}
