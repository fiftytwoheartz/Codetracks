using System;

namespace Codetracks.Core
{
	public class ContractImplementationBase
	{
		protected void ValidatePredicateOrThrow<TArg>(TArg arg, Tuple<Func<TArg, bool>, string> predicate)
		{
			if (!predicate.Item1(arg))
			{
				throw new ArgumentException(
					$"Predicate violated with value '{arg}' of type '{typeof(TArg).FullName}'.\r\n" + 
					$"Details: '{predicate.Item2}'.");
			}
		}
	}
}