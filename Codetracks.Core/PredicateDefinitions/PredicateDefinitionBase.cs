using System;

namespace Codetracks.Core.PredicateDefinitions {

    public abstract class PredicateDefinitionBase<T> {

        protected readonly Func<T, bool> _predicate;

        public readonly string Description;

        protected PredicateDefinitionBase(
            Func<T, bool> predicate,
            string description) {
            Description = description;
            _predicate = predicate;
        }

        public abstract PredicateDefinitionBase<T> And(
            PredicateDefinitionBase<T> predicateDefinition);

        public abstract PredicateDefinitionBase<T> Or(
            PredicateDefinitionBase<T> predicateDefinition);

        public abstract PredicateDefinitionBase<T> Not();

        public bool Eval(
            T parameter) {
            return _predicate(parameter);
        }

    }

}