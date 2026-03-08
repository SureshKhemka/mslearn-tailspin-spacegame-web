namespace TailSpin.SpaceGame.Web.Services.Providers
{
    public class Apollo247PriceProvider : BaseLabTestPriceProvider
    {
        public override string ProviderName => "Apollo 24*7";
        protected override string BookingBaseUrl => "https://www.apollo247.com/lab-tests/search?searchQuery=";
    }
}
