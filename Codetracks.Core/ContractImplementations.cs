using System;

using Codetracks.Core.PredicateDefinitions;

namespace Codetracks.Core {

    /*
     * Represents a complete, properly defined and implemented contract.
     * These classes are intedent to be published as a public properties throught client's classes.
     */

    #region TArg1

    public class OneArgVoidContractImplementation<TArg1> : ContractImplementationBase {

        private readonly PredicateDefinitionBase<TArg1> _arg1_predicateWithDesc;

        private readonly Action<TArg1> _func;

        internal OneArgVoidContractImplementation(
            PredicateDefinitionBase<TArg1> arg1_predicateWithDesc,
            Action<TArg1> func) {
            _arg1_predicateWithDesc = arg1_predicateWithDesc;
            _func = func;
        }

        public void Invoke(
            TArg1 arg1) {
            ValidatePredicateOrThrow(
                1,
                arg1,
                _arg1_predicateWithDesc);
            _func(arg1);
        }

    }

    public class OneArgContractImplementation<TArg1, TRes> : ContractImplementationBase {

        private readonly PredicateDefinitionBase<TArg1> _arg1_predicateWithDesc;

        private readonly Func<TArg1, TRes> _func;

        private readonly PredicateDefinitionBase<TRes> _res_predicateWithDesc;

        internal OneArgContractImplementation(
            PredicateDefinitionBase<TArg1> arg1_predicateWithDesc,
            PredicateDefinitionBase<TRes> res_predicateWithDesc,
            Func<TArg1, TRes> func) {
            _arg1_predicateWithDesc = arg1_predicateWithDesc;
            _res_predicateWithDesc = res_predicateWithDesc;
            _func = func;
        }

        public TRes Invoke(
            TArg1 arg1) {
            ValidatePredicateOrThrow(
                1,
                arg1,
                _arg1_predicateWithDesc);
            var res = _func(arg1);
            ValidatePredicateOrThrow(
                0,
                res,
                _res_predicateWithDesc);
            return res;
        }

    }

    #endregion

    #region TArg1, TArg2

    public class TwoArgsVoidContractImplementation<TArg1, TArg2> : ContractImplementationBase {

        private readonly PredicateDefinitionBase<TArg1> _arg1_predicateWithDesc;

        private readonly PredicateDefinitionBase<TArg2> _arg2_predicateWithDesc;

        private readonly Action<TArg1, TArg2> _func;

        internal TwoArgsVoidContractImplementation(
            PredicateDefinitionBase<TArg1> arg1_predicateWithDesc,
            PredicateDefinitionBase<TArg2> arg2_predicateWithDesc,
            Action<TArg1, TArg2> func) {
            _arg1_predicateWithDesc = arg1_predicateWithDesc;
            _arg2_predicateWithDesc = arg2_predicateWithDesc;
            _func = func;
        }

        public Action<TArg2> Invoke(
            TArg1 arg1) {
            ValidatePredicateOrThrow(
                1,
                arg1,
                _arg1_predicateWithDesc);
            return arg2 => {
                ValidatePredicateOrThrow(
                    2,
                    arg2,
                    _arg2_predicateWithDesc);
                _func(
                    arg1,
                    arg2);
            };
        }

    }

    public class TwoArgsContractImplementation<TArg1, TArg2, TRes> : ContractImplementationBase {

        private readonly PredicateDefinitionBase<TArg1> _arg1_predicateWithDesc;

        private readonly PredicateDefinitionBase<TArg2> _arg2_predicateWithDesc;

        private readonly Func<TArg1, TArg2, TRes> _func;

        private readonly PredicateDefinitionBase<TRes> _res_predicateWithDesc;

        internal TwoArgsContractImplementation(
            PredicateDefinitionBase<TArg1> arg1_predicateWithDesc,
            PredicateDefinitionBase<TArg2> arg2_predicateWithDesc,
            PredicateDefinitionBase<TRes> res_predicateWithDesc,
            Func<TArg1, TArg2, TRes> func) {
            _arg1_predicateWithDesc = arg1_predicateWithDesc;
            _arg2_predicateWithDesc = arg2_predicateWithDesc;
            _res_predicateWithDesc = res_predicateWithDesc;
            _func = func;
        }

        public Func<TArg2, TRes> Invoke(
            TArg1 arg1) {
            ValidatePredicateOrThrow(
                1,
                arg1,
                _arg1_predicateWithDesc);
            return arg2 => {
                ValidatePredicateOrThrow(
                    2,
                    arg2,
                    _arg2_predicateWithDesc);
                var res = _func(
                    arg1,
                    arg2);
                ValidatePredicateOrThrow(
                    0,
                    res,
                    _res_predicateWithDesc);
                return res;
            };
        }

    }

    #endregion

    #region TArg1, TArg2, TArg3

    public class ThreeArgsVoidContractImplementation<TArg1, TArg2, TArg3> : ContractImplementationBase {

        private readonly PredicateDefinitionBase<TArg1> _arg1_predicateWithDesc;

        private readonly PredicateDefinitionBase<TArg2> _arg2_predicateWithDesc;

        private readonly PredicateDefinitionBase<TArg3> _arg3_predicateWithDesc;

        private readonly Action<TArg1, TArg2, TArg3> _func;

        internal ThreeArgsVoidContractImplementation(
            PredicateDefinitionBase<TArg1> arg1_predicateWithDesc,
            PredicateDefinitionBase<TArg2> arg2_predicateWithDesc,
            PredicateDefinitionBase<TArg3> arg3_predicateWithDesc,
            Action<TArg1, TArg2, TArg3> func) {
            _arg1_predicateWithDesc = arg1_predicateWithDesc;
            _arg2_predicateWithDesc = arg2_predicateWithDesc;
            _arg3_predicateWithDesc = arg3_predicateWithDesc;
            _func = func;
        }

        public Func<TArg2, Action<TArg3>> Invoke(
            TArg1 arg1) {
            ValidatePredicateOrThrow(
                1,
                arg1,
                _arg1_predicateWithDesc);
            return arg2 => {
                ValidatePredicateOrThrow(
                    2,
                    arg2,
                    _arg2_predicateWithDesc);
                return arg3 => {
                    ValidatePredicateOrThrow(
                        3,
                        arg3,
                        _arg3_predicateWithDesc);
                    _func(
                        arg1,
                        arg2,
                        arg3);
                };
            };
        }

    }

    public class ThreeArgsContractImplementation<TArg1, TArg2, TArg3, TRes> : ContractImplementationBase {

        private readonly PredicateDefinitionBase<TArg1> _arg1_predicateWithDesc;

        private readonly PredicateDefinitionBase<TArg2> _arg2_predicateWithDesc;

        private readonly PredicateDefinitionBase<TArg3> _arg3_predicateWithDesc;

        private readonly Func<TArg1, TArg2, TArg3, TRes> _func;

        private readonly PredicateDefinitionBase<TRes> _res_predicateWithDesc;

        internal ThreeArgsContractImplementation(
            PredicateDefinitionBase<TArg1> arg1_predicateWithDesc,
            PredicateDefinitionBase<TArg2> arg2_predicateWithDesc,
            PredicateDefinitionBase<TArg3> arg3_predicateWithDesc,
            PredicateDefinitionBase<TRes> res_predicateWithDesc,
            Func<TArg1, TArg2, TArg3, TRes> func) {
            _arg1_predicateWithDesc = arg1_predicateWithDesc;
            _arg2_predicateWithDesc = arg2_predicateWithDesc;
            _arg3_predicateWithDesc = arg3_predicateWithDesc;
            _res_predicateWithDesc = res_predicateWithDesc;
            _func = func;
        }

        public Func<TArg2, Func<TArg3, TRes>> Invoke(
            TArg1 arg1) {
            ValidatePredicateOrThrow(
                1,
                arg1,
                _arg1_predicateWithDesc);
            return arg2 => {
                ValidatePredicateOrThrow(
                    2,
                    arg2,
                    _arg2_predicateWithDesc);
                return arg3 => {
                    ValidatePredicateOrThrow(
                        3,
                        arg3,
                        _arg3_predicateWithDesc);
                    var res = _func(
                        arg1,
                        arg2,
                        arg3);
                    ValidatePredicateOrThrow(
                        0,
                        res,
                        _res_predicateWithDesc);
                    return res;
                };
            };
        }

    }

    #endregion

}