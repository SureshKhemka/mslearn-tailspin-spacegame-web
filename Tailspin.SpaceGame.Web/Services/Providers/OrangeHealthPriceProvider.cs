namespace TailSpin.SpaceGame.Web.Services.Providers
{
    public class OrangeHealthPriceProvider : BaseLabTestPriceProvider
    {
        public override string ProviderName => "Orange Health";
        protected override string BookingBaseUrl => "https://www.orangehealth.in/search?q=";
    }
}
