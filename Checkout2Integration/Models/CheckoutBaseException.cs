using System;
using System.Net;

namespace Checkout.Integration.Models
{
    public abstract class CheckoutBaseException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public string ReasonPhrase { get; set; }

        public CheckoutExceptionResponse CheckoutException { get; set; }

        public CheckoutBaseException() { }

        public CheckoutBaseException(string reasonPhrase) {
            ReasonPhrase = reasonPhrase;
        }

        public CheckoutBaseException(HttpStatusCode statusCode, string reasonPhrase)
        {
            StatusCode = statusCode;
            ReasonPhrase = reasonPhrase;
        }
    }
}
