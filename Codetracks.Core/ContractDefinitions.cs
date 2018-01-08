using System;

namespace Codetracks.Core
{
	#region TArg1

	public class OneArgVoidContractDefinition<TArg1> : InputDefinitionOwner<TArg1>
	{
		private readonly InputDefinition<TArg1> _inputDefinition;

		public OneArgVoidContractDefinition(InputDefinition<TArg1> arg1Definition)
			: base(arg1Definition)
		{
		}

		public OneArgVoidContractImplementation<TArg1> Implement(Action<TArg1> func)
		{
			return new OneArgVoidContractImplementation<TArg1>(_inputDefinition.Arg1Predicate, func);
		}
	}

	public class OneArgContractDefinition<TArg1, TRes> : InputDefinitionOwner<TArg1>
	{
		private readonly Tuple<Func<TRes, bool>, string> _predicateWithDesc;


		public OneArgContractDefinition(InputDefinition<TArg1> arg1Definition, Tuple<Func<TRes, bool>, string> predicateWithDesc)
			: base(arg1Definition)
		{
			_predicateWithDesc = predicateWithDesc;
		}

		public OneArgContractImplementation<TArg1, TRes> Implement(Func<TArg1, TRes> func)
		{
			return new OneArgContractImplementation<TArg1, TRes>(Arg1Definition.Arg1Predicate, _predicateWithDesc, func);
		}
	}

	#endregion
	
	#region TArg1, TArg2

	public class TwoArgsVoidContractDefinition<TArg1, TArg2> : InputDefinitionOwner<TArg1, TArg2>
	{
		private readonly InputDefinition<TArg1, TArg2> _inputDefinition;


		public TwoArgsVoidContractDefinition(InputDefinition<TArg1, TArg2> arg2Definition)
			: base(arg2Definition)
		{
		}

		public TwoArgsVoidContractImplementation<TArg1, TArg2> Implement(Action<TArg1, TArg2> func)
		{
			return new TwoArgsVoidContractImplementation<TArg1, TArg2>(_inputDefinition.Arg1Predicate, _inputDefinition.Arg2Predicate, func);
		}
	}

	public class TwoArgsContractDefinition<TArg1, TArg2, TRes> : InputDefinitionOwner<TArg1, TArg2>
	{
		private readonly Tuple<Func<TRes, bool>, string> _predicateWithDesc;

		private Func<TArg1, TArg2, TRes> _func;

		public TwoArgsContractDefinition(InputDefinition<TArg1, TArg2> arg2Definition, Tuple<Func<TRes, bool>, string> predicateWithDesc)
			: base(arg2Definition)
		{
			_predicateWithDesc = predicateWithDesc;
		}

		public TwoArgsContractImplementation<TArg1, TArg2, TRes> Implement(Func<TArg1, TArg2, TRes> func)
		{
			return new TwoArgsContractImplementation<TArg1, TArg2, TRes>(Arg2Definition.Arg1Predicate, Arg2Definition.Arg2Predicate, _predicateWithDesc, func);
		}
	}

	#endregion


}