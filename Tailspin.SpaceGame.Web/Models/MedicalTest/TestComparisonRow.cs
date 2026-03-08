using System.Collections.Generic;
using System.Linq;

namespace TailSpin.SpaceGame.Web.Models.MedicalTest
{
    public class TestComparisonRow
    {
        public string TestName { get; set; }
        public List<TestPriceResult> ProviderPrices { get; set; } = new List<TestPriceResult>();

        public TestPriceResult CheapestProvider =>
            ProviderPrices
                .Where(p => p.IsAvailable)
                .OrderBy(p => p.Price)
                .FirstOrDefault();
    }
}
