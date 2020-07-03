using System;

namespace Checkout.Integration.Client
{
    public class AuthenticatorHelper
    {
        protected string MerchantCode;

        protected string MerchantSecret;

        public AuthenticatorHelper(string merchantCode, string merchantSecret)
        {
            MerchantCode = merchantCode;
            MerchantSecret = merchantSecret;
        }

        public string GetAuthToken()
        {
            string date = GetTransactionDate();
            string hash = BuildHash(date);

            return $"code=\"{MerchantCode}\" date=\"{date}\" hash=\"{hash}\"";
        }

        protected string BuildHash(string date)
        {
            return Crypto.MakeHash(MerchantCode.Length + MerchantCode + date.Length + date, MerchantSecret);
        }

        protected string GetTransactionDate()
        {
            return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }

}
