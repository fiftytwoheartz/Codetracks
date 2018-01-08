using System;

namespace Codetracks.Core
{
	public class ContractDefinition<TArg1> : InputDefinitionOwner<TArg1>
	{
		private readonly InputDefinition<TArg1> _inputDefinition;

		private Action<TArg1> _func;

		public ContractDefinition(InputDefinition<TArg1> inputDefinition)
			: base(inputDefinition)
		{
		}

		public void Implement(Action<TArg1> func)
		{
			_func = func;
		}
	}

	public class ContractDefinition<TArg1, TRes> : InputDefinitionOwner<TArg1>
	{
		private readonly Tuple<Func<TRes, bool>, string> _predicateWithDesc;

		private Func<TArg1, TRes> _func;

		public ContractDefinition(InputDefinition<TArg1> inputDefinition, Tuple<Func<TRes, bool>, string> predicateWithDesc)
			: base(inputDefinition)
		{
			_predicateWithDesc = predicateWithDesc;
		}

		public void Implement(Func<TArg1, TRes> func)
		{
			_func = func;
		}
	}
}