﻿using Codetracks.Core.PredicateDefinitions;

namespace Codetracks.Core {

    /// <summary>
    ///     Just a shorthand to define a contract.
    ///     Note: client can't access internal constructors, thus this class provides the only possible contract creation.
    /// </summary>
    public class MethodContract {

        // Singleton.
        public static MethodContract Define { get; } = new MethodContract();

        public InputDefinition<TArg1> FirstParameter<TArg1>(
            IPredicateDefinition<TArg1> predicateWithDesc) {
            return new InputDefinition<TArg1>(predicateWithDesc);
        }

    }

}