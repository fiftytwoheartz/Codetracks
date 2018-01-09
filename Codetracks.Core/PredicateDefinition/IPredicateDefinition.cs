using System;

namespace Codetracks.Core.PredicateDefinition
{
    public interface IPredicateDefinition<T>
    {
        Tuple<Func<T, bool>, string> TupleDefinition { get; }

        IPredicateDefinition<T> And(Func<T, bool> func, string exceptionMessage);

        IPredicateDefinition<T> Or(Func<T, bool> func, string exceptionMessage);
    }
}