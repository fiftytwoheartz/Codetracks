using System.Threading.Tasks;

using Codetracks.Core;

namespace Codetracks.Sandbox {

    public class UsageExample : IUsageExampleContract
    {
        public UsageExample() {
            AddIntegersMethodContract = 
                MethodContract
                    .Define
                    .FirstParameter(Predicates.Int32.Positive)
                    .SecondParameter(Predicates.Int32.Positive)
                    .Returns(Predicates.Int32.Positive)
                    .Implement(AddIntegers);
            AddIntegersAsyncMethodContract =
                MethodContract
                    .Define
                    .FirstParameter(Predicates.Int32.Positive)
                    .SecondParameter(Predicates.Int32.Positive)
                    .Returns<Task<int>>()
                    .Implement(AddIntegersAsync);
        }

        public TwoArgsContractImplementation<int, int, int> AddIntegersMethodContract { get; }

        private static int AddIntegers(
            int x,
            int y) {
            return x + y;
        }

        public TwoArgsContractImplementation<int, int, Task<int>> AddIntegersAsyncMethodContract { get; }

        private static Task<int> AddIntegersAsync(
            int x,
            int y) {
            return Task.FromResult(x + y);
        }

    }

}