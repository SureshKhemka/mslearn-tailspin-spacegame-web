namespace TailSpin.SpaceGame.Web.Models.MedicalTest
{
    public class TestPriceResult
    {
        public string TestName { get; set; }
        public string ProviderName { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string BookingUrl { get; set; }
    }
}
