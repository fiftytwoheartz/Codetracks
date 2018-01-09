using System.Threading.Tasks;
using Codetracks.Core;

namespace Codetracks.Sandbox
{
    public interface IUsageExampleContract
    {
        TwoArgsContractImplementation<int, int, Task<int>> AddIntegersAsyncMethodContract { get; }
        TwoArgsContractImplementation<int, int, int> AddIntegersMethodContract { get; }
    }
}