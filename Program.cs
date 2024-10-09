using System;

namespace BinaryStringEvaluator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary string:");
            string? input = Console.ReadLine(); // Allow input to be nullable

            try
            {
                bool result = Evaluator.IsGoodBinaryString(input);
                Console.WriteLine($"Is the binary string good? {result}");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Input cannot be null. Please enter a valid binary string.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
