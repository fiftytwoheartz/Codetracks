using System;

namespace Codetracks.Core.PredicateDefinition
{
    public class PredicateDefinition<T> : IPredicateDefinition<T>
    {
        public PredicateDefinition()
        {

        }

        public PredicateDefinition(Tuple<Func<T, bool>, string> tuple)
        {
            TupleDefinition = tuple;
        }

        public Tuple<Func<T, bool>, string> TupleDefinition { get; }

        public static PredicateDefinition<T> Create(Func<T, bool> func, string exceptionMessage)
        {
            return new PredicateDefinition<T>(Tuple.Create(func, exceptionMessage));
        }

        public IPredicateDefinition<T> And(Func<T, bool> func, string exceptionMessage)
        {
            return new AndPredicateDefinition<T>(this, new PredicateDefinition<T>(Tuple.Create(func, exceptionMessage)));
        }

        public IPredicateDefinition<T> Or(Func<T, bool> func, string exceptionMessage)
        {
            return new OrPredicateDefinition<T>(this, new PredicateDefinition<T>(Tuple.Create(func, exceptionMessage)));
        }
    }
}
