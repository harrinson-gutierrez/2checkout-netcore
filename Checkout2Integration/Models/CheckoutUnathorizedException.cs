
using System;
using System.Net;
using System.Net.Http;

namespace Checkout.Integration.Models
{
    public class CheckoutUnathorizedException : CheckoutBaseException
    {

        public CheckoutUnathorizedException()
        {
            StatusCode = HttpStatusCode.Unauthorized;
        }

        public CheckoutUnathorizedException(string reasonPhrase) : base(reasonPhrase)
        {
            StatusCode = HttpStatusCode.Unauthorized;
        }

    }
}
