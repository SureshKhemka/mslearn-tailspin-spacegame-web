using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TailSpin.SpaceGame.Web.Models.MedicalTest;

namespace TailSpin.SpaceGame.Web.Services
{
    public class TestPriceComparisonService
    {
        private readonly IEnumerable<ILabTestPriceProvider> _providers;

        public TestPriceComparisonService(IEnumerable<ILabTestPriceProvider> providers)
        {
            _providers = providers;
        }

        public async Task<ComparisonViewModel> CompareAsync(TestSearchQuery query)
        {
            var providerList = _providers.ToList();
            var providerNames = providerList.Select(p => p.ProviderName).ToList();

            // Fetch prices from all providers concurrently
            var allProviderResults = await Task.WhenAll(
                providerList.Select(p => p.GetPricesAsync(query.ParsedTestNames, query.Location))
            );

            // Build comparison rows grouped by canonical test name
            // Use the resolved canonical name from the first available result per input
            var testRows = new List<TestComparisonRow>();
            var resolvedNames = new Dictionary<string, string>(); // inputName -> canonicalName

            // Collect all unique canonical test names returned
            foreach (var providerResults in allProviderResults)
            {
                foreach (var result in providerResults.Where(r => r.IsAvailable))
                {
                    if (!resolvedNames.ContainsValue(result.TestName))
                    {
                        // Find the original input that resolved to this canonical name
                        var original = query.ParsedTestNames.FirstOrDefault(
                            t => MockPriceData.ResolveTestName(t) == result.TestName);
                        if (original != null && !resolvedNames.ContainsKey(original))
                            resolvedNames[original] = result.TestName;
                    }
                }
            }

            // For inputs that couldn't be resolved, keep the original
            foreach (var input in query.ParsedTestNames)
            {
                if (!resolvedNames.ContainsKey(input))
                    resolvedNames[input] = input;
            }

            // Build one row per input test
            foreach (var input in query.ParsedTestNames)
            {
                var canonicalName = resolvedNames.TryGetValue(input, out var name) ? name : input;

                var row = new TestComparisonRow
                {
                    TestName = canonicalName,
                    ProviderPrices = new List<TestPriceResult>()
                };

                // Add one price result per provider (preserving provider order)
                for (int i = 0; i < providerList.Count; i++)
                {
                    var providerResults = allProviderResults[i];
                    var result = providerResults.FirstOrDefault(r =>
                        r.TestName == canonicalName || r.TestName == input);

                    if (result != null)
                    {
                        row.ProviderPrices.Add(result);
                    }
                    else
                    {
                        row.ProviderPrices.Add(new TestPriceResult
                        {
                            TestName = canonicalName,
                            ProviderName = providerList[i].ProviderName,
                            IsAvailable = false,
                            Price = 0,
                            BookingUrl = "#"
                        });
                    }
                }

                testRows.Add(row);
            }

            return new ComparisonViewModel
            {
                Query = query,
                Results = testRows,
                ProviderNames = providerNames
            };
        }
    }
}
