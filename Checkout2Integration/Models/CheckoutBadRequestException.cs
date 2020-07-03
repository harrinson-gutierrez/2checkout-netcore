using System.Net;

namespace Checkout.Integration.Models
{
    public class CheckoutBadRequestException : CheckoutBaseException
    {
        public CheckoutBadRequestException()
        {
            StatusCode = HttpStatusCode.BadRequest;
        }
        public CheckoutBadRequestException(string reasonPhrase) : base(reasonPhrase)
        {
            StatusCode = HttpStatusCode.BadRequest;
        }

        public CheckoutBadRequestException(HttpStatusCode statusCode, string reasonPhrase) : base(statusCode, reasonPhrase) { }

    }
}
