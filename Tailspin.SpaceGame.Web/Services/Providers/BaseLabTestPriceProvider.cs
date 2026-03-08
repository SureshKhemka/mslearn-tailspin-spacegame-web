using System.Collections.Generic;
using System.Threading.Tasks;
using TailSpin.SpaceGame.Web.Models.MedicalTest;

namespace TailSpin.SpaceGame.Web.Services.Providers
{
    public abstract class BaseLabTestPriceProvider : ILabTestPriceProvider
    {
        public abstract string ProviderName { get; }
        protected abstract string BookingBaseUrl { get; }

        public Task<List<TestPriceResult>> GetPricesAsync(List<string> testNames, string location)
        {
            var results = new List<TestPriceResult>();
            var cityMultiplier = MockPriceData.GetCityMultiplier(location);

            foreach (var inputName in testNames)
            {
                var canonicalName = MockPriceData.ResolveTestName(inputName);

                if (canonicalName == null ||
                    !MockPriceData.BasePrices.TryGetValue(canonicalName, out var providerPrices) ||
                    !providerPrices.TryGetValue(ProviderName, out var basePrice))
                {
                    results.Add(new TestPriceResult
                    {
                        TestName = inputName,
                        ProviderName = ProviderName,
                        IsAvailable = false,
                        Price = 0,
                        BookingUrl = "#"
                    });
                    continue;
                }

                var finalPrice = decimal.Round(basePrice * cityMultiplier, 0);

                results.Add(new TestPriceResult
                {
                    TestName = canonicalName,
                    ProviderName = ProviderName,
                    IsAvailable = true,
                    Price = finalPrice,
                    BookingUrl = $"{BookingBaseUrl}{System.Uri.EscapeDataString(canonicalName)}"
                });
            }

            return Task.FromResult(results);
        }
    }
}
