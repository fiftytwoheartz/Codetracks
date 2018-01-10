using System;
using System.Diagnostics;

using Codetracks.Core.PredicateDefinitions;

namespace Codetracks.Core {

    public class ContractImplementationBase {

        /// <summary>
        ///     [Conditional("DEBUG")] indicates that compiler should
        ///     wipe out all calls to this method whenever project
        ///     was compiled under something different than "DEBUG".
        ///     Good questions is how to make such a behavior more flexible,
        ///     such that some custom compile symbols could be introduced as well?
        /// </summary>
        /// <typeparam name="TArg"></typeparam>
        /// <param name="argIndex"></param>
        /// <param name="arg"></param>
        /// <param name="predicate"></param>
        [Conditional("DEBUG")]
        protected static void ValidatePredicateOrThrow<TArg>(
            byte argIndex,
            TArg arg,
            PredicateDefinitionBase<TArg> predicate) {
            if (!predicate.Eval(arg))
                throw new ArgumentException(
                    $"Predicate violated with value '{arg}'{DecideWhetherIndexHasToBeSpecified(argIndex)} of type '{typeof(TArg).FullName}'.\r\n" +
                    $"Details: '{predicate.Description}'.");
        }

        /// <summary>
        ///     By conventions argIndex=0 means that the result of the method rather than the argument is validated.
        ///     As such there is no need to include argument's index in the message.
        /// </summary>
        /// <param name="argIndex"></param>
        /// <returns></returns>
        private static string DecideWhetherIndexHasToBeSpecified(
            byte argIndex) {
            return argIndex == 0
                ? string.Empty
                : $", which is {StringifyIndex(argIndex)} argument";
        }

        private static string StringifyIndex(
            byte argIndex) {
            switch (argIndex) {
                case 1:
                    return "1st";
                case 2:
                    return "2nd";
                case 3:
                    return "3rd";
                default:
                    return $"{argIndex}th";
            }
        }

    }

}