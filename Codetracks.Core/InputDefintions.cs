using System;

namespace Codetracks.Core
{
	public class InputDefinition<TArg1>
	{
		public readonly Tuple<Func<TArg1, bool>, string> Arg1Predicate;

		public InputDefinition(Tuple<Func<TArg1, bool>, string> arg1Predicate)
		{
			Arg1Predicate = arg1Predicate;
		}

		public InputDefinition<TArg1, TArg2> Takes<TArg2>(Tuple<Func<TArg2, bool>, string> arg2Predicate)
		{
			return new InputDefinition<TArg1, TArg2>(Arg1Predicate, arg2Predicate);
		}

		public OneArgContractDefinition<TArg1, TRes> Returns<TRes>(Tuple<Func<TRes, bool>, string> resultPredicateWithDesc = null)
		{
			return new OneArgContractDefinition<TArg1, TRes>(this, resultPredicateWithDesc ?? Tuple.Create<Func<TRes, bool>, string>(res => true, string.Empty));
		}

		public OneArgVoidContractDefinition<TArg1> ReturnsVoid()
		{
			return new OneArgVoidContractDefinition<TArg1>(this);
		}
	}

	public class InputDefinition<TArg1, TArg2> : InputDefinition<TArg1>
	{
		public readonly Tuple<Func<TArg2, bool>, string> Arg2Predicate;

		public InputDefinition(
			Tuple<Func<TArg1, bool>, string> arg1Predicate,
			Tuple<Func<TArg2, bool>, string> arg2Predicate)
			: base(arg1Predicate)
		{
			Arg2Predicate = arg2Predicate;
		}

		public new TwoArgsContractDefinition<TArg1, TArg2, TRes> Returns<TRes>(Tuple<Func<TRes, bool>, string> resultPredicateWithDesc = null)
		{
			return new TwoArgsContractDefinition<TArg1, TArg2, TRes>(this, resultPredicateWithDesc ?? Tuple.Create<Func<TRes, bool>, string>(res => true, string.Empty));
		}

		public TwoArgsVoidContractDefinition<TArg1, TArg2> ReturnsVoid()
		{
			return new TwoArgsVoidContractDefinition<TArg1, TArg2>(this);
		}
	}
}