using System;

namespace Codetracks.Core
{
	public class MethodContract
	{
		// Singleton.
		public static MethodContract Define { get; } = new MethodContract();

		public InputDefinition<TArg1> Takes<TArg1>(Tuple<Func<TArg1, bool>, string> predicateWithDesc)
		{
			return new InputDefinition<TArg1>(predicateWithDesc);
		}
	}
}