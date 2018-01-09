using System;

using Codetracks.Core.PredicateDefinitions;

namespace Codetracks.Core
{
	public static class Predicates
	{
		public static class Int32
		{
			public static Tuple<Func<int, bool>, string> Positive => Tuple.Create<Func<int, bool>, string>(arg => arg >= 0, $"Expected positive {nameof(Int32)}.");
			public static Tuple<Func<int, bool>, string> Negative => Tuple.Create<Func<int, bool>, string>(arg => arg < 0, $"Expected negative {nameof(Int32)}.");
		}

        public static IPredicateDefinition<T> Define<T>(Func<T, bool> func, string description)
        {
            return new PredicateDefinition<T>(func, description);
        }
	}
}