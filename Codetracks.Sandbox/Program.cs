using System;

using Codetracks.Core;

namespace Codetracks.Sandbox
{
	class Program
	{
		static void Main(string[] args)
		{
			var shouldBePositivePredicate = Tuple.Create<Func<int, bool>, string>(i => i > 0, "Should be positive.");

			MethodContract
				.Define
				.Takes(shouldBePositivePredicate)
				.Takes(shouldBePositivePredicate)
				.Returns(shouldBePositivePredicate)
				.Implement((leftValue, rightValue) => leftValue + rightValue);

			Console.Read();
		}
	}
}