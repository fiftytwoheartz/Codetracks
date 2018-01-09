using System;

namespace Codetracks.Core.PredicateDefinitions
{
    public interface IPredicateDefinition<T>
    {
        Tuple<Func<T, bool>, string> AsTuple { get; }

        IPredicateDefinition<T> And(IPredicateDefinition<T> predicateDefinition);

        IPredicateDefinition<T> Or(IPredicateDefinition<T> predicateDefinition);

        IPredicateDefinition<T> Not();

        string Description { get; }

        bool Eval(
            T parameter);

    }
}