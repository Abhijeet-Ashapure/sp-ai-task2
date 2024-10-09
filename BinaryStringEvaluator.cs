using System;

namespace BinaryStringEvaluator
{
    public class Evaluator
    {
        /// <summary>
        /// Checks if the provided binary string is "good".
        /// A binary string is "good" if it has an equal number of '0's and '1's,
        /// and for every prefix, the number of '1's is not less than the number of '0's.
        /// </summary>
        /// <param name="binaryString">The binary string to evaluate.</param>
        /// <returns>True if the string is good; otherwise, false.</returns>
        /// <exception cref="ArgumentException">Thrown when the input is not a valid binary string.</exception>
        public static bool IsGoodBinaryString(string? binaryString)
        {
            if (binaryString == null)
            {
                throw new ArgumentNullException(nameof(binaryString), "Input cannot be null.");
            }

            int count0 = 0, count1 = 0;

            foreach (char c in binaryString)
            {
                if (c == '0') count0++;
                else if (c == '1') count1++;
                else throw new ArgumentException("Input must be a binary string containing only '0's and '1's.");

                if (count0 > count1) return false; // Prefix condition
            }

            return count0 == count1; // Equal count check
        }

    }
}
