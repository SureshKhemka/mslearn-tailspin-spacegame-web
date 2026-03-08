using System.Collections.Generic;
using System.Linq;

namespace TailSpin.SpaceGame.Web.Models.MedicalTest
{
    public class TestSearchQuery
    {
        public string TestNames { get; set; }
        public string Location { get; set; }

        public List<string> ParsedTestNames =>
            TestNames?.Split(',')
                .Select(t => t.Trim())
                .Where(t => !string.IsNullOrEmpty(t))
                .ToList()
            ?? new List<string>();
    }
}
