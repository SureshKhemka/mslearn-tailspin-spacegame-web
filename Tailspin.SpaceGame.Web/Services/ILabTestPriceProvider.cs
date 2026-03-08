using System.Collections.Generic;
using System.Threading.Tasks;
using TailSpin.SpaceGame.Web.Models.MedicalTest;

namespace TailSpin.SpaceGame.Web.Services
{
    public interface ILabTestPriceProvider
    {
        string ProviderName { get; }
        Task<List<TestPriceResult>> GetPricesAsync(List<string> testNames, string location);
    }
}
