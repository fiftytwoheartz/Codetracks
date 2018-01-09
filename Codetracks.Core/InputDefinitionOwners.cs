namespace Codetracks.Core {

    public abstract class InputDefinitionOwner<TArg1> {

        protected readonly InputDefinition<TArg1> _inputDefinition;

        protected InputDefinitionOwner(
            InputDefinition<TArg1> inputDefinition) {
            _inputDefinition = inputDefinition;
        }

    }

    public abstract class InputDefinitionOwner<TArg1, TArg2> {

        protected readonly InputDefinition<TArg1, TArg2> _inputDefinition;

        protected InputDefinitionOwner(
            InputDefinition<TArg1, TArg2> inputDefinition) {
            _inputDefinition = inputDefinition;
        }

    }

    public abstract class InputDefinitionOwner<TArg1, TArg2, TArg3> {

        protected readonly InputDefinition<TArg1, TArg2, TArg3> _inputDefinition;

        protected InputDefinitionOwner(
            InputDefinition<TArg1, TArg2, TArg3> inputDefinition) {
            _inputDefinition = inputDefinition;
        }

    }

}