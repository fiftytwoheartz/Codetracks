using System;

namespace Codetracks.Core.PredicateDefinition
{
    public class OrPredicateDefinition<T> : BinnaryPredicateDefinition<T>
    {
        public OrPredicateDefinition(IPredicateDefinition<T> left, IPredicateDefinition<T> right) : base(left, right)
        {

        }

        public override Tuple<Func<T, bool>, string> TupleDefinition { get => CombineTuples(); }

        private Tuple<Func<T, bool>, string> CombineTuples()
        {
            return new Tuple<Func<T, bool>, string>(arg =>
                LeftPredicate.TupleDefinition.Item1(arg) || RightPredicate.TupleDefinition.Item1(arg),
                $"{LeftPredicate.TupleDefinition.Item2}\n{RightPredicate.TupleDefinition.Item2}");
        }
    }
}
