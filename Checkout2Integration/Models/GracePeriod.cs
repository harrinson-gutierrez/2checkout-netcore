namespace Checkout.Integration.Models
{
    public class GracePeriod
    {
        public string Type { get; set; }
        public string PeriodUnits { get; set; }
        public int Period { get; set; }
        public bool IsUnlimited { get; set; }
    }
}
