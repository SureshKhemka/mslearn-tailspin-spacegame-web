namespace TailSpin.SpaceGame.Web.Services.Providers
{
    public class Tata1mgPriceProvider : BaseLabTestPriceProvider
    {
        public override string ProviderName => "Tata 1mg";
        protected override string BookingBaseUrl => "https://www.1mg.com/lab-tests/search?name=";
    }
}
