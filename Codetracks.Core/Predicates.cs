﻿using System;

using Codetracks.Core.PredicateDefinitions;

namespace Codetracks.Core {

    /// <summary>
    ///     Shorthand to a pretty standartd, widely-used predicates.
    /// </summary>
    public static class Predicates {

        public static PredicateDefinitionBase<T> Define<T>(
            Func<T, bool> func,
            string description) {
            return new PredicateDefinition<T>(
                func,
                description);
        }

        public static PredicateDefinitionBase<TRes> AlwaysTrue<TRes>() {
            return new PredicateDefinition<TRes>(
                res => true,
                string.Empty);
        }

        public static class Int32 {

            public static PredicateDefinitionBase<int> Positive => new PredicateDefinition<int>(
                arg => arg >= 0,
                $"Expected positive {nameof(Int32)}.");

            public static PredicateDefinitionBase<int> Negative => new PredicateDefinition<int>(
                arg => arg < 0,
                $"Expected negative {nameof(Int32)}.");

        }

    }

}