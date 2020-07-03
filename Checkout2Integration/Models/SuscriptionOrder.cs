namespace Checkout.Integration.Models
{
    public class SuscriptionOrder
    {
        public string RefNo { get; set; }
        public string Status { get; set; }
        public int FailedRecurringChargesCount { get; set; }
    }
}
