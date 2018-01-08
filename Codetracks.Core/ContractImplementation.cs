using System;

namespace Codetracks.Core
{
	#region TArg1

	public class OneArgVoidContractImplementation<TArg1>
	{
		private readonly Tuple<Func<TArg1, bool>, string> _arg1_predicateWithDesc;

		private readonly Action<TArg1> _func;

		public OneArgVoidContractImplementation(Tuple<Func<TArg1, bool>, string> arg1_predicateWithDesc, Action<TArg1> func)
		{
			_arg1_predicateWithDesc = arg1_predicateWithDesc;
			_func = func;
		}

		public void Invoke(TArg1 arg1)
		{
			if (!_arg1_predicateWithDesc.Item1(arg1))
			{
				throw new ArgumentException(_arg1_predicateWithDesc.Item2);
			}

			_func(arg1);
		}
	}

	public class OneArgContractImplementation<TArg1, TRes>
	{
		private readonly Tuple<Func<TArg1, bool>, string> _arg1_predicateWithDesc;
		private readonly Tuple<Func<TRes, bool>, string> _res_predicateWithDesc;

		private readonly Func<TArg1, TRes> _func;

		public OneArgContractImplementation(
			Tuple<Func<TArg1, bool>, string> arg1_predicateWithDesc, 
			Tuple<Func<TRes, bool>, string> res_predicateWithDesc, 
			Func<TArg1, TRes> func)
		{
			_arg1_predicateWithDesc = arg1_predicateWithDesc;
			_res_predicateWithDesc = res_predicateWithDesc;
			_func = func;
		}

		public TRes Invoke(TArg1 arg1)
		{
			if (!_arg1_predicateWithDesc.Item1(arg1))
			{
				throw new ArgumentException(_arg1_predicateWithDesc.Item2);
			}

			var res = _func(arg1);

			if (!_res_predicateWithDesc.Item1(res))
			{
				throw new ArgumentException(_res_predicateWithDesc.Item2);
			}

			return res;
		}
	}

	#endregion
	
	#region TArg1, TArg2

	public class TwoArgsVoidContractImplementation<TArg1, TArg2>
	{
		private readonly Tuple<Func<TArg1, bool>, string> _arg1_predicateWithDesc;

		private readonly Tuple<Func<TArg2, bool>, string> _arg2_predicateWithDesc;

		private readonly Action<TArg1, TArg2> _func;

		public TwoArgsVoidContractImplementation(
			Tuple<Func<TArg1, bool>, string> arg1_predicateWithDesc, 
			Tuple<Func<TArg2, bool>, string> arg2_predicateWithDesc, 
			Action<TArg1, TArg2> func)
		{
			_arg1_predicateWithDesc = arg1_predicateWithDesc;
			_arg2_predicateWithDesc = arg2_predicateWithDesc;
			_func = func;
		}

		public Action<TArg2> Invoke(TArg1 arg1)
		{
			if (!_arg1_predicateWithDesc.Item1(arg1))
			{
				throw new ArgumentException(_arg1_predicateWithDesc.Item2);
			}

			return arg2 =>
				{
					if (!_arg2_predicateWithDesc.Item1(arg2))
					{
						throw new ArgumentException(_arg2_predicateWithDesc.Item2);
					}

					_func(arg1, arg2);
				};
		}
	}

	public class TwoArgsContractImplementation<TArg1, TArg2, TRes>
	{
		private readonly Tuple<Func<TArg1, bool>, string> _arg1_predicateWithDesc;
		private readonly Tuple<Func<TArg2, bool>, string> _arg2_predicateWithDesc;
		private readonly Tuple<Func<TRes, bool>, string> _res_predicateWithDesc;

		private readonly Func<TArg1, TArg2, TRes> _func;

		public TwoArgsContractImplementation(
			Tuple<Func<TArg1, bool>, string> arg1_predicateWithDesc,
			Tuple<Func<TArg2, bool>, string> arg2_predicateWithDesc,
			Tuple<Func<TRes, bool>, string> res_predicateWithDesc,
			Func<TArg1, TArg2, TRes> func)
		{
			_arg1_predicateWithDesc = arg1_predicateWithDesc;
			_arg2_predicateWithDesc = arg2_predicateWithDesc;
			_res_predicateWithDesc = res_predicateWithDesc;
			_func = func;
		}

		public Func<TArg2, TRes> Invoke(TArg1 arg1)
		{
			if (!_arg1_predicateWithDesc.Item1(arg1))
			{
				throw new ArgumentException(_arg1_predicateWithDesc.Item2);
			}

			return arg2 =>
				{
					if (!_arg2_predicateWithDesc.Item1(arg2))
					{
						throw new ArgumentException(_arg2_predicateWithDesc.Item2);
					}

					var res = _func(arg1, arg2);

					if (!_res_predicateWithDesc.Item1(res))
					{
						throw new ArgumentException(_res_predicateWithDesc.Item2);
					}

					return res;
				};
		}
	}

	#endregion
}