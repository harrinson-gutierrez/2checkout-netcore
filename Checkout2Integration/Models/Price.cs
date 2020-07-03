namespace Checkout.Integration.Models
{
    public class Price
    {
        public float Amount { get; set; }
        public string Currency { get; set; }
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }
    }
}
