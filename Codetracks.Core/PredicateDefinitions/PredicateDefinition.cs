using System;

namespace Codetracks.Core.PredicateDefinitions {

    public class PredicateDefinition<T> : PredicateDefinitionBase<T> {

        internal PredicateDefinition(
            Func<T, bool> predicate,
            string description) : base(
            predicate,
            description) { }

        public override PredicateDefinitionBase<T> And(
            PredicateDefinitionBase<T> predicateDefinition) {
            return new PredicateDefinition<T>(
                arg => _predicate(arg) && predicateDefinition.Eval(arg),
                Description + "---AND---" + predicateDefinition.Description);
        }

        public override PredicateDefinitionBase<T> Or(
            PredicateDefinitionBase<T> predicateDefinition) {
            return new PredicateDefinition<T>(
                arg => _predicate(arg) || predicateDefinition.Eval(arg),
                Description + "---OR---" + predicateDefinition.Description);
        }

        public override PredicateDefinitionBase<T> Not() {
            return new PredicateDefinition<T>(
                arg => !_predicate(arg),
                "[---NOT---] " + Description);
        }

    }

}