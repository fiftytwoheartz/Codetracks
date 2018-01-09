namespace Codetracks.Core.PredicateDefinitions {

    public interface IPredicateDefinition<T> {

        string Description { get; }

        IPredicateDefinition<T> And(
            IPredicateDefinition<T> predicateDefinition);

        IPredicateDefinition<T> Or(
            IPredicateDefinition<T> predicateDefinition);

        IPredicateDefinition<T> Not();

        bool Eval(
            T parameter);

    }

}