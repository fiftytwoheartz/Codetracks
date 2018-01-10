using Codetracks.Core.PredicateDefinitions;

namespace Codetracks.Core {

    /// <summary>
    ///     Just a shorthand to define a contract.
    ///     Note: client can't access internal constructors, thus this class provides the only possible contract creation.
    /// </summary>
    public class MethodContract {


        public static MethodContract Define() {
            return new MethodContract();
        }

        public InputDefinition<TArg1> FirstParameter<TArg1>(
            PredicateDefinitionBase<TArg1> predicateWithDesc) {
            return new InputDefinition<TArg1>(predicateWithDesc);
        }

    }

}