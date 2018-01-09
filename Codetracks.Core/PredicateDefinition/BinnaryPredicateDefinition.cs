using System;

namespace Codetracks.Core.PredicateDefinition
{
    public class BinnaryPredicateDefinition<T> : IPredicateDefinition<T>
    {
        public BinnaryPredicateDefinition(IPredicateDefinition<T> left, IPredicateDefinition<T> right)
        {
            LeftPredicate = left;
            RightPredicate = right;
        }

        public IPredicateDefinition<T> LeftPredicate { get; protected set; }

        public IPredicateDefinition<T> RightPredicate { get; protected set; }

        public virtual Tuple<Func<T, bool>, string> TupleDefinition { get; protected set; }

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
