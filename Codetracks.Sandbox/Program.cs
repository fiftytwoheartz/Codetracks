using System;

using Codetracks.Core;

namespace Codetracks.Sandbox
{
	class Program
	{
		static void Main(string[] args)
		{
			MethodContract
				.Define
				.Takes(Predicates.Int32.Positive)
				.Takes(Predicates.Int32.Positive)
				.Returns(Predicates.Int32.Positive)
				.Implement((leftValue, rightValue) => leftValue + rightValue)
				.Invoke
					(1) // first arg meets the requirement
					(-1); // second arg violates the requirement

			Console.Read();
		}
	}
}