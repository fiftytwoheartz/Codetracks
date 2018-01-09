using System;

namespace Codetracks.Core {

    /*
     * InputDefinitons are responsible for function's arguments. The logic is obvious: 
     * from [n]-parameters func one can either terminate the definiton with ReturnsVoid()/Returns<TRes>(...) invokation,
     * or move toward [n+1]-parameters func definition; then the whole idea repreats.
     */

    #region TArg1

    public class InputDefinition<TArg1> {

        public readonly Tuple<Func<TArg1, bool>, string> Arg1Predicate;

        public InputDefinition(
            Tuple<Func<TArg1, bool>, string> arg1Predicate) {
            Arg1Predicate = arg1Predicate;
        }

        public InputDefinition<TArg1, TArg2> Takes<TArg2>(
            Tuple<Func<TArg2, bool>, string> arg2Predicate) {
            return new InputDefinition<TArg1, TArg2>(
                Arg1Predicate,
                arg2Predicate);
        }

        public OneArgContractDefinition<TArg1, TRes> Returns<TRes>(
            Tuple<Func<TRes, bool>, string> resultPredicateWithDesc = null) {
            return new OneArgContractDefinition<TArg1, TRes>(
                this,
                resultPredicateWithDesc ?? Tuple.Create<Func<TRes, bool>, string>(
                    res => true,
                    string.Empty));
        }

        public OneArgVoidContractDefinition<TArg1> ReturnsVoid() {
            return new OneArgVoidContractDefinition<TArg1>(this);
        }

    }

    #endregion

    #region TArg1, TArg2

    public class InputDefinition<TArg1, TArg2> : InputDefinition<TArg1> {

        public readonly Tuple<Func<TArg2, bool>, string> Arg2Predicate;

        public InputDefinition(
            Tuple<Func<TArg1, bool>, string> arg1Predicate,
            Tuple<Func<TArg2, bool>, string> arg2Predicate)
            : base(arg1Predicate) {
            Arg2Predicate = arg2Predicate;
        }

        public new InputDefinition<TArg1, TArg2, TArg3> Takes<TArg3>(
            Tuple<Func<TArg3, bool>, string> arg3Predicate)
        {
            return new InputDefinition<TArg1, TArg2, TArg3>(
                Arg1Predicate,
                Arg2Predicate,
                arg3Predicate);
        }

        public new TwoArgsContractDefinition<TArg1, TArg2, TRes> Returns<TRes>(
            Tuple<Func<TRes, bool>, string> resultPredicateWithDesc = null) {
            return new TwoArgsContractDefinition<TArg1, TArg2, TRes>(
                this,
                resultPredicateWithDesc ?? Tuple.Create<Func<TRes, bool>, string>(
                    res => true,
                    string.Empty));
        }

        public new TwoArgsVoidContractDefinition<TArg1, TArg2> ReturnsVoid() {
            return new TwoArgsVoidContractDefinition<TArg1, TArg2>(this);
        }

    }

    #endregion 
    
    #region TArg1, TArg2, TArg3

    public class InputDefinition<TArg1, TArg2, TArg3> : InputDefinition<TArg1, TArg2> {

        public readonly Tuple<Func<TArg3, bool>, string> Arg3Predicate;

        public InputDefinition(
            Tuple<Func<TArg1, bool>, string> arg1Predicate,
            Tuple<Func<TArg2, bool>, string> arg2Predicate,
            Tuple<Func<TArg3, bool>, string> arg3Predicate)
            : base(arg1Predicate, arg2Predicate) {
            Arg3Predicate = arg3Predicate;
        }

        public new ThreeArgsContractDefinition<TArg1, TArg2, TArg3, TRes> Returns<TRes>(
            Tuple<Func<TRes, bool>, string> resultPredicateWithDesc = null)
        {
            return new ThreeArgsContractDefinition<TArg1, TArg2, TArg3, TRes>(
                this,
                resultPredicateWithDesc ?? Tuple.Create<Func<TRes, bool>, string>(
                    res => true,
                    string.Empty));
        }

        public new ThreeArgsVoidContractDefinition<TArg1, TArg2, TArg3> ReturnsVoid()
        {
            return new ThreeArgsVoidContractDefinition<TArg1, TArg2, TArg3>(this);
        }

    }

    #endregion

}