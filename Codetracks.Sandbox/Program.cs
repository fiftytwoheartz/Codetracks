using System;

using Codetracks.Core;

namespace Codetracks.Sandbox
{
	class Program
	{
		static void Main(string[] args)
		{
			var message = string.Empty;

			try
			{
				var res = 
					MethodContract
						.Define
                        .Takes(Predicates.Define<int>(arg => arg > 0, $"expected number more than 0")
                            .And(arg => arg < 100, "expected number less than 100").TupleDefinition)
                        .Takes(Predicates.Define<int>(arg => arg < 0, "expected number less than 0")
                            .Or(arg => arg > 100, "expected number more than 100").TupleDefinition)
						.Returns(Predicates.Int32.Positive)
						.Implement((leftValue, rightValue) => leftValue + rightValue)
						.Invoke
							(-1) // first arg violates the requirement
                            (101); // second arg violates the requirement

				message = res.ToString();
			}
			catch (ArgumentException argumentException)
			{
				message = argumentException.Message;
			}

			Console.WriteLine(message);
			
			Console.Read();
		}
	}
}