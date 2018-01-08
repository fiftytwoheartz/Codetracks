using System;

namespace Codetracks.Core
{
	public class InputDefinition<TArg1>
	{
		private readonly Tuple<Func<TArg1, bool>, string> _arg1_predicateWithDesc;

		public InputDefinition(Tuple<Func<TArg1, bool>, string> arg1_predicateWithDesc)
		{
			_arg1_predicateWithDesc = arg1_predicateWithDesc;
		}

		public InputDefinition<TArg1, TArg2> Takes<TArg2>(Tuple<Func<TArg2, bool>, string> predicateWithDesc)
		{
			return new InputDefinition<TArg1, TArg2>(_arg1_predicateWithDesc, predicateWithDesc);
		}

		public OneArgContractDefinition<TArg1, TRes> Returns<TRes>(Tuple<Func<TRes, bool>, string> predicateWithDesc = null)
		{
			return new OneArgContractDefinition<TArg1, TRes>(this, predicateWithDesc ?? Tuple.Create<Func<TRes, bool>, string>(res => true, String.Empty));
		}

		public OneArgVoidContractDefinition<TArg1> ReturnsVoid()
		{
			return new OneArgVoidContractDefinition<TArg1>(this);
		}
	}

	public class InputDefinition<TArg1, TArg2> : InputDefinition<TArg1>
	{
		private readonly Tuple<Func<TArg2, bool>, string> _arg2_predicateWithDesc;

		public InputDefinition(
			Tuple<Func<TArg1, bool>, string> arg1_PredicateWithDesc,
			Tuple<Func<TArg2, bool>, string> arg2_predicateWithDesc)
			: base(arg1_PredicateWithDesc)
		{
			_arg2_predicateWithDesc = arg2_predicateWithDesc;
		}

		public new TwoArgsContractDefinition<TArg1, TArg2, TRes> Returns<TRes>(Tuple<Func<TRes, bool>, string> predicateWithDesc = null)
		{
			return new TwoArgsContractDefinition<TArg1, TArg2, TRes>(this, predicateWithDesc ?? Tuple.Create<Func<TRes, bool>, string>(res => true, String.Empty));
		}

		public TwoArgsVoidContractDefinition<TArg1, TArg2> ReturnsVoid()
		{
			return new TwoArgsVoidContractDefinition<TArg1, TArg2>(this);
		}
	}
}