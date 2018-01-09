using System;

namespace Codetracks.Core {

    /*
     * Represents a well-defined, but not yet implemented contract.
     * This is the last step before the contract becomes pratically usable: 
     * as soon as implementation provided, contract could be invoked frow wherever one wishes.
     */

    #region TArg1

    public class OneArgVoidContractDefinition<TArg1> : InputDefinitionOwner<TArg1> {

        internal OneArgVoidContractDefinition(
            InputDefinition<TArg1> inputDefinition)
            : base(inputDefinition) { }

        public OneArgVoidContractImplementation<TArg1> Implement(
            Action<TArg1> func) {
            return new OneArgVoidContractImplementation<TArg1>(
                _inputDefinition.Current,
                func);
        }

    }

    public class OneArgContractDefinition<TArg1, TRes> : InputDefinitionOwner<TArg1> {

        private readonly Tuple<Func<TRes, bool>, string> _resultPredicateWithDesc;

        internal OneArgContractDefinition(
            InputDefinition<TArg1> inputDefinition,
            Tuple<Func<TRes, bool>, string> resultPredicateWithDesc)
            : base(inputDefinition) {
            _resultPredicateWithDesc = resultPredicateWithDesc;
        }

        public OneArgContractImplementation<TArg1, TRes> Implement(
            Func<TArg1, TRes> func) {
            return new OneArgContractImplementation<TArg1, TRes>(
                _inputDefinition.Current,
                _resultPredicateWithDesc,
                func);
        }

    }

    #endregion

    #region TArg1, TArg2

    public class TwoArgsVoidContractDefinition<TArg1, TArg2> : InputDefinitionOwner<TArg1, TArg2> {

        internal TwoArgsVoidContractDefinition(
            InputDefinition<TArg1, TArg2> inputDefinition)
            : base(inputDefinition) { }

        public TwoArgsVoidContractImplementation<TArg1, TArg2> Implement(
            Action<TArg1, TArg2> func) {
            return new TwoArgsVoidContractImplementation<TArg1, TArg2>(
                _inputDefinition.Parent.Current,
                _inputDefinition.Current,
                func);
        }

    }

    public class TwoArgsContractDefinition<TArg1, TArg2, TRes> : InputDefinitionOwner<TArg1, TArg2> {

        private readonly Tuple<Func<TRes, bool>, string> _resultPredicateWithDesc;

        internal TwoArgsContractDefinition(
            InputDefinition<TArg1, TArg2> inputDefinition,
            Tuple<Func<TRes, bool>, string> resultPredicateWithDesc)
            : base(inputDefinition) {
            _resultPredicateWithDesc = resultPredicateWithDesc;
        }

        public TwoArgsContractImplementation<TArg1, TArg2, TRes> Implement(
            Func<TArg1, TArg2, TRes> func) {
            return new TwoArgsContractImplementation<TArg1, TArg2, TRes>(
                _inputDefinition.Parent.Current,
                _inputDefinition.Current,
                _resultPredicateWithDesc,
                func);
        }

    }

    #endregion

    #region TArg1, TArg2, TArg3

    public class ThreeArgsVoidContractDefinition<TArg1, TArg2, TArg3> : InputDefinitionOwner<TArg1, TArg2, TArg3> {

        internal ThreeArgsVoidContractDefinition(
            InputDefinition<TArg1, TArg2, TArg3> inputDefinition)
            : base(inputDefinition) { }

        public TwoArgsVoidContractImplementation<TArg1, TArg2> Implement(
            Action<TArg1, TArg2> func) {
            return new TwoArgsVoidContractImplementation<TArg1, TArg2>(
                _inputDefinition.Parent.Parent.Current,
                _inputDefinition.Parent.Current,
                func);
        }

    }

    public class ThreeArgsContractDefinition<TArg1, TArg2, TArg3, TRes> : InputDefinitionOwner<TArg1, TArg2, TArg3> {

        private readonly Tuple<Func<TRes, bool>, string> _resultPredicateWithDesc;

        internal ThreeArgsContractDefinition(
            InputDefinition<TArg1, TArg2, TArg3> inputDefinition,
            Tuple<Func<TRes, bool>, string> resultPredicateWithDesc)
            : base(inputDefinition) {
            _resultPredicateWithDesc = resultPredicateWithDesc;
        }

        public ThreeArgsContractImplementation<TArg1, TArg2, TArg3, TRes> Implement(
            Func<TArg1, TArg2, TArg3, TRes> func) {
            return new ThreeArgsContractImplementation<TArg1, TArg2, TArg3, TRes>(
                _inputDefinition.Parent.Parent.Current,
                _inputDefinition.Parent.Current,
                _inputDefinition.Current,
                _resultPredicateWithDesc,
                func);
        }

    }

    #endregion

}