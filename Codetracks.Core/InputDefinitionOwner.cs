namespace Codetracks.Core
{
	public abstract class InputDefinitionOwner<TArg1>
	{
		public readonly InputDefinition<TArg1> InputDefinition;

		protected InputDefinitionOwner(InputDefinition<TArg1> inputDefinition)
		{
			InputDefinition = inputDefinition;
		}
	}

	public abstract class InputDefinitionOwner<TArg1, TArg2>
	{
		public readonly InputDefinition<TArg1, TArg2> _inputDefinition;

		protected InputDefinitionOwner(
			InputDefinition<TArg1, TArg2> inputDefinition)
		{
			_inputDefinition = inputDefinition;
		}
	}
}