using System;

namespace Codetracks.Core
{
	#region TArg1

	public class OneArgVoidContractDefinition<TArg1> : InputDefinitionOwner<TArg1>
	{
		private readonly InputDefinition<TArg1> _inputDefinition;

		public OneArgVoidContractDefinition(InputDefinition<TArg1> inputDefinition)
			: base(inputDefinition)
		{
		}

		public OneArgVoidContractImplementation<TArg1> Implement(Action<TArg1> func)
		{
			return new OneArgVoidContractImplementation<TArg1>(_inputDefinition._arg1_predicateWithDesc, func);
		}
	}

	public class OneArgContractDefinition<TArg1, TRes> : InputDefinitionOwner<TArg1>
	{
		private readonly Tuple<Func<TRes, bool>, string> _predicateWithDesc;


		public OneArgContractDefinition(InputDefinition<TArg1> inputDefinition, Tuple<Func<TRes, bool>, string> predicateWithDesc)
			: base(inputDefinition)
		{
			_predicateWithDesc = predicateWithDesc;
		}

		public OneArgContractImplementation<TArg1, TRes> Implement(Func<TArg1, TRes> func)
		{
			return new OneArgContractImplementation<TArg1, TRes>(InputDefinition._arg1_predicateWithDesc, _predicateWithDesc, func);
		}
	}

	#endregion
	
	#region TArg1, TArg2

	public class TwoArgsVoidContractDefinition<TArg1, TArg2> : InputDefinitionOwner<TArg1, TArg2>
	{
		private readonly InputDefinition<TArg1, TArg2> _inputDefinition;


		public TwoArgsVoidContractDefinition(InputDefinition<TArg1, TArg2> inputDefinition)
			: base(inputDefinition)
		{
		}

		public TwoArgsVoidContractImplementation<TArg1, TArg2> Implement(Action<TArg1, TArg2> func)
		{
			return new TwoArgsVoidContractImplementation<TArg1, TArg2>(_inputDefinition._arg1_predicateWithDesc, _inputDefinition._arg2_predicateWithDesc, func);
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

		public TwoArgsContractImplementation<TArg1, TArg2, TRes> Implement(Func<TArg1, TArg2, TRes> func)
		{
			return new TwoArgsContractImplementation<TArg1, TArg2, TRes>(_inputDefinition._arg1_predicateWithDesc, _inputDefinition._arg2_predicateWithDesc, _predicateWithDesc, func);
		}
	}

	#endregion


}