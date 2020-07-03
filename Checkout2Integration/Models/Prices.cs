using System.Collections.Generic;

namespace Checkout.Integration.Models
{
    public class Prices
    {
        public List<Price> Regular { get; set; }
        public List<Price> Renewal { get; set; }
    }
}
