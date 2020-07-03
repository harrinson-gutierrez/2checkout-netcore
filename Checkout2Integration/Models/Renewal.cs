namespace Checkout.Integration.Models
{
    public class Renewal
    {
        public bool Before30Days { get; set; }
        public bool Before15Days { get; set; }
        public bool Before7Days { get; set; }
        public bool Before1Day { get; set; }
        public bool OnExpirationDate { get; set; }
        public bool After5Days { get; set; }
        public bool After15Days { get; set; }
    }
}
