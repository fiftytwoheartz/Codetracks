using System;

namespace Codetracks.Core.PredicateDefinitions {

    public class PredicateDefinition<T> : IPredicateDefinition<T> {

        private readonly Func<T, bool> _predicate;

        internal PredicateDefinition(
            Func<T, bool> predicate,
            string description) {
            _predicate = predicate;
            Description = description;
        }

        public Tuple<Func<T, bool>, string> AsTuple => new Tuple<Func<T, bool>, string>(
            _predicate,
            Description);

        public IPredicateDefinition<T> And(
            IPredicateDefinition<T> predicateDefinition) {
            return new PredicateDefinition<T>(
                arg => _predicate(arg) && predicateDefinition.Eval(arg),
                Description + "---AND---" + predicateDefinition.Description);
        }

        public IPredicateDefinition<T> Or(
            IPredicateDefinition<T> predicateDefinition) {
            return new PredicateDefinition<T>(
                arg => _predicate(arg) || predicateDefinition.Eval(arg),
                Description + "---OR---" + predicateDefinition.Description);
        }

        public IPredicateDefinition<T> Not() {
            return new PredicateDefinition<T>(
                arg => !_predicate(arg),
                "[---NOT---] " + Description);
        }

        public string Description { get; }

        public bool Eval(
            T parameter) {
            return _predicate(parameter);
        }

    }

}