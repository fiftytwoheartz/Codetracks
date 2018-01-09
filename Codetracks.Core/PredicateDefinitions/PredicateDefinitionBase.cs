using System;

namespace Codetracks.Core.PredicateDefinitions {

    public abstract class PredicateDefinitionBase<T> {

        protected readonly Func<T, bool> _predicate;

        protected PredicateDefinitionBase(
            Func<T, bool> func,
            string description) {
            Description = description;
            _predicate = func;
        }

        public string Description { get; }

        public abstract PredicateDefinitionBase<T> And(
            PredicateDefinitionBase<T> predicateDefinition);

        public abstract PredicateDefinitionBase<T> Or(
            PredicateDefinitionBase<T> predicateDefinition);

        public abstract PredicateDefinitionBase<T> Not();

        public bool Eval(
            T parameter) => _predicate(parameter);

    }

}