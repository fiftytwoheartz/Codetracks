using System;

namespace Codetracks.Core
{
	public class InputDefinition<TArg1>
	{
		private readonly Tuple<Func<TArg1, bool>, string> _arg1PredicateWithDesc;

		public InputDefinition(Tuple<Func<TArg1, bool>, string> arg1PredicateWithDesc)
		{
			_arg1PredicateWithDesc = arg1PredicateWithDesc;
		}

		public InputDefinition<TArg1, TArg2> Takes<TArg2>(Tuple<Func<TArg2, bool>, string> predicateWithDesc)
		{
			return new InputDefinition<TArg1, TArg2>(_arg1PredicateWithDesc, predicateWithDesc);
		}

		public ContractDefinition<TArg1, TRes> Returns<TRes>(Tuple<Func<TRes, bool>, string> predicateWithDesc = null)
		{
			return new ContractDefinition<TArg1, TRes>(this, predicateWithDesc);
		}

		public ContractDefinition<TArg1> ReturnsVoid()
		{
			return new ContractDefinition<TArg1>(this);
		}
	}

	public class InputDefinition<TArg1, TArg2> : InputDefinition<TArg1>
	{
		private readonly Tuple<Func<TArg2, bool>, string> _arg2PredicateWithDesc;

		public InputDefinition(
			Tuple<Func<TArg1, bool>, string> arg1PredicateWithDesc,
			Tuple<Func<TArg2, bool>, string> arg2PredicateWithDesc)
			: base(arg1PredicateWithDesc)
		{
			_arg2PredicateWithDesc = arg2PredicateWithDesc;
		}
	}
}