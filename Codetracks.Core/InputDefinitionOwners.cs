namespace Codetracks.Core
{
	public abstract class InputDefinitionOwner<TArg1>
	{
		public readonly InputDefinition<TArg1> Arg1Definition;

		protected InputDefinitionOwner(InputDefinition<TArg1> arg1Definition)
		{
			Arg1Definition = arg1Definition;
		}
	}

	public abstract class InputDefinitionOwner<TArg1, TArg2>
	{
		public readonly InputDefinition<TArg1, TArg2> Arg2Definition;

		protected InputDefinitionOwner(
			InputDefinition<TArg1, TArg2> arg2Definition)
		{
			Arg2Definition = arg2Definition;
		}
	}
}