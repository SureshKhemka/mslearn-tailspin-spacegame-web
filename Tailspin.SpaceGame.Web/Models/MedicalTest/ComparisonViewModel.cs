using System.Collections.Generic;
using System.Linq;

namespace TailSpin.SpaceGame.Web.Models.MedicalTest
{
    public class ComparisonViewModel
    {
        public TestSearchQuery Query { get; set; }
        public List<TestComparisonRow> Results { get; set; } = new List<TestComparisonRow>();
        public List<string> ProviderNames { get; set; } = new List<string>();
        public bool HasResults => Results != null && Results.Any();

        public decimal TotalSavings
        {
            get
            {
                if (!HasResults) return 0;
                decimal maxTotal = Results.Sum(r =>
                    r.ProviderPrices.Where(p => p.IsAvailable).Select(p => p.Price).DefaultIfEmpty(0).Max());
                decimal minTotal = Results.Sum(r =>
                    r.CheapestProvider?.Price ?? 0);
                return maxTotal - minTotal;
            }
        }
    }
}
