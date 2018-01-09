using System;

namespace Codetracks.Sandbox {

    internal class Program {

        private static void Main(
            string[] args) {
            // the most convinient way to define public contracts is interface
            IUsageExampleContract usageExampleContract = new UsageExample();

            try {
                Console.WriteLine("\r\n\r\nValid parameters:\r\n");
                // curring is a free bonus:
                // exception will be thrown at the same exact moment when wrong parameter appears
                Console.WriteLine($"Sync addition: {usageExampleContract.AddIntegersMethodContract.Invoke(1)(1)}");

                Console.WriteLine("\r\n\r\nInvalid parameter:\r\n");

                // works with async/await feature nicely: 
                // all the predicates are evaluated synchronously,
                // just the contract's implementation awaited
                Console.WriteLine($"Async addition: {usageExampleContract.AddIntegersAsyncMethodContract.Invoke(1)(-1).Result}");
            }

            // throws standard ArgumentException when contract violated
            catch (ArgumentException argumentException) {
                Console.WriteLine(argumentException);
            }

            Console.Read();
        }

    }

}