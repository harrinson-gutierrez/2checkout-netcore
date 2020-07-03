namespace Checkout.Integration.Models
{
    public class ContractPeriod
    {
        public string Action { get; set; }
        public bool EmailsDuringContract { get; set; }
        public int Period { get; set; }
        public string PeriodUnits { get; set; }
        public bool IsUnlimited { get; set; }
    }
}
