using System;

namespace Codetracks.Core {

    public class ContractImplementationBase {

        protected static void ValidatePredicateOrThrow<TArg>(
            byte argIndex,
            TArg arg,
            Tuple<Func<TArg, bool>, string> predicate) {
            if (!predicate.Item1(arg))
                throw new ArgumentException(
                    $"Predicate violated with value '{arg}'{DecideWhetherIndexHasToBeSpecified(argIndex)} of type '{typeof(TArg).FullName}'.\r\n" +
                    $"Details: '{predicate.Item2}'.");
        }

        /// <summary>
        /// By conventions argIndex=0 means that the result of the method rather than the argument is validated.
        /// As such there is no need to include argument's index in the message.
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
            if (argIndex == 1) {
                return "1st";
            }

            if (argIndex == 2) {
                return "2nd";
            }

            if (argIndex == 3) {
                return "3rd";
            }

            return $"{argIndex}th";
        }

    }

}