﻿using Codetracks.Core.PredicateDefinitions;

namespace Codetracks.Core {

    /*
     * InputDefinitons are responsible for function's arguments. The logic is obvious: 
     * from [n]-parameters func one can either terminate the definiton with ReturnsVoid()/Returns<TRes>(...) invokation,
     * or move toward [n+1]-parameters func definition; then the whole idea repreats.
     */

    #region TArg1

    public class InputDefinition<TArg1> {

        public readonly PredicateDefinitionBase<TArg1> Current;

        public InputDefinition(
            PredicateDefinitionBase<TArg1> current) {
            Current = current;
        }

        public InputDefinition<TArg1, TArg2> SecondParameter<TArg2>(
            PredicateDefinitionBase<TArg2> arg2Predicate) {
            return new InputDefinition<TArg1, TArg2>(
                this,
                arg2Predicate);
        }

        public OneArgContractDefinition<TArg1, TRes> Returns<TRes>(
            PredicateDefinitionBase<TRes> resultPredicateWithDesc = null) {
            return new OneArgContractDefinition<TArg1, TRes>(
                this,
                resultPredicateWithDesc ?? Predicates.AlwaysTrue<TRes>());
        }

        public OneArgVoidContractDefinition<TArg1> ReturnsVoid() {
            return new OneArgVoidContractDefinition<TArg1>(this);
        }

    }

    #endregion

    #region TArg1, TArg2

    public class InputDefinition<TArg1, TArg2> {

        public readonly PredicateDefinitionBase<TArg2> Current;

        public readonly InputDefinition<TArg1> Parent;

        public InputDefinition(
            InputDefinition<TArg1> parent,
            PredicateDefinitionBase<TArg2> current) {
            Parent = parent;
            Current = current;
        }

        public InputDefinition<TArg1, TArg2, TArg3> ThrirdParameter<TArg3>(
            PredicateDefinitionBase<TArg3> arg3Predicate) {
            return new InputDefinition<TArg1, TArg2, TArg3>(
                this,
                arg3Predicate);
        }

        public TwoArgsContractDefinition<TArg1, TArg2, TRes> Returns<TRes>(
            PredicateDefinitionBase<TRes> resultPredicateWithDesc = null) {
            return new TwoArgsContractDefinition<TArg1, TArg2, TRes>(
                this,
                resultPredicateWithDesc ?? Predicates.AlwaysTrue<TRes>());
        }

        public TwoArgsVoidContractDefinition<TArg1, TArg2> ReturnsVoid() {
            return new TwoArgsVoidContractDefinition<TArg1, TArg2>(this);
        }

    }

    #endregion

    #region TArg1, TArg2, TArg3

    public class InputDefinition<TArg1, TArg2, TArg3> {

        public readonly PredicateDefinitionBase<TArg3> Current;

        public readonly InputDefinition<TArg1, TArg2> Parent;

        public InputDefinition(
            InputDefinition<TArg1, TArg2> parent,
            PredicateDefinitionBase<TArg3> current) {
            Parent = parent;
            Current = current;
        }

        public ThreeArgsContractDefinition<TArg1, TArg2, TArg3, TRes> Returns<TRes>(
            PredicateDefinitionBase<TRes> resultPredicateWithDesc = null) {
            return new ThreeArgsContractDefinition<TArg1, TArg2, TArg3, TRes>(
                this,
                resultPredicateWithDesc ?? Predicates.AlwaysTrue<TRes>());
        }

        public ThreeArgsVoidContractDefinition<TArg1, TArg2, TArg3> ReturnsVoid() {
            return new ThreeArgsVoidContractDefinition<TArg1, TArg2, TArg3>(this);
        }

    }

    #endregion

}