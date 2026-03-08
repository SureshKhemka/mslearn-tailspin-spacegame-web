namespace TailSpin.SpaceGame.Web.Services.Providers
{
    public class PharmEasyPriceProvider : BaseLabTestPriceProvider
    {
        public override string ProviderName => "PharmEasy";
        protected override string BookingBaseUrl => "https://pharmeasy.in/online-medicine-order/search?name=";
    }
}
