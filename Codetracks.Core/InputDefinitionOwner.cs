namespace Codetracks.Core
{
	public abstract class InputDefinitionOwner<TArg1>
	{
		protected readonly InputDefinition<TArg1> _inputDefinition;

		protected InputDefinitionOwner(InputDefinition<TArg1> inputDefinition)
		{
			_inputDefinition = inputDefinition;
		}
	}
}