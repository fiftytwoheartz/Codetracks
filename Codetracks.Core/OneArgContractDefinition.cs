using System;

namespace Codetracks.Core
{
	#region TArg1

	public class OneArgVoidContractDefinition<TArg1> : InputDefinitionOwner<TArg1>
	{
		private readonly InputDefinition<TArg1> _inputDefinition;

		private Action<TArg1> _func;

		public OneArgVoidContractDefinition(InputDefinition<TArg1> inputDefinition)
			: base(inputDefinition)
		{
		}

		public void Implement(Action<TArg1> func)
		{
			_func = func;
		}
	}

	public class OneArgContractDefinition<TArg1, TRes> : InputDefinitionOwner<TArg1>
	{
		private readonly Tuple<Func<TRes, bool>, string> _predicateWithDesc;

		private Func<TArg1, TRes> _func;

		public OneArgContractDefinition(InputDefinition<TArg1> inputDefinition, Tuple<Func<TRes, bool>, string> predicateWithDesc)
			: base(inputDefinition)
		{
			_predicateWithDesc = predicateWithDesc;
		}

		public void Implement(Func<TArg1, TRes> func)
		{
			_func = func;
		}
	}

	#endregion
	
	#region TArg1, TArg2

	public class TwoArgsVoidContractDefinition<TArg1, TArg2> : InputDefinitionOwner<TArg1, TArg2>
	{
		private readonly InputDefinition<TArg1, TArg2> _inputDefinition;

		private Action<TArg1, TArg2> _func;

		public TwoArgsVoidContractDefinition(InputDefinition<TArg1, TArg2> inputDefinition)
			: base(inputDefinition)
		{
		}

		public void Implement(Action<TArg1, TArg2> func)
		{
			_func = func;
		}
	}

	public class TwoArgsContractDefinition<TArg1, TArg2, TRes> : InputDefinitionOwner<TArg1, TArg2>
	{
		private readonly Tuple<Func<TRes, bool>, string> _predicateWithDesc;

		private Func<TArg1, TArg2, TRes> _func;

		public TwoArgsContractDefinition(InputDefinition<TArg1, TArg2> inputDefinition, Tuple<Func<TRes, bool>, string> predicateWithDesc)
			: base(inputDefinition)
		{
			_predicateWithDesc = predicateWithDesc;
		}

		public void Implement(Func<TArg1, TArg2, TRes> func)
		{
			_func = func;
		}
	}

	#endregion


}