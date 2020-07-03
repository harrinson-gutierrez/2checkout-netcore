using System;
using System.Security.Cryptography;
using System.Text;

namespace Checkout.Integration
{
    public class Crypto
    {
        /// <summary>
        /// Created Hash
        /// </summary>
        /// <param name="text">Text to hash</param>
        /// <param name="key">Key for the hash</param>
        /// <returns>Hash</returns>
        public static string MakeHash(string text, string key) 
        {
            Console.WriteLine(text);
            var byteData = Encoding.UTF8.GetBytes(text);

            var bytesKey = Encoding.UTF8.GetBytes(key);

            var hmac = new HMACMD5(bytesKey);

            var hashBytes = hmac.ComputeHash(byteData);
            StringBuilder ret = new StringBuilder();

            for (int i = 0; i < hashBytes.Length; i++)
                ret.Append(hashBytes[i].ToString("x2"));

            return ret.ToString();
 
        }
    }
}
