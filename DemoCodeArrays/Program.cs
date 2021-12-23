using System;

namespace DemoCodeArrays
{
    class Program
    {
        public static void PrintNumbers(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i]} ");
            }
            Console.WriteLine("");
        }

        // int[] values = reference to object
        // so we can change original object
        public static void ResetNumbers(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = 0;
            }
        }

        public static int SumOfNumbers(int[] values)
        {
            int total = 0;
            for (int i = 0; i < values.Length; i++)
            {
                total += values[i];
            }

            return total;
        }

        public static int IndexOfMinimum(int[] values)
        {
            // Check
            if (values.Length == 0)
            {
                return -1;
            }

            int iMinimum = 0;       // We start with values[0] as minimum

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < values[iMinimum])
                {
                    iMinimum = i;
                }
            }

            return iMinimum;
        }

        public static int ValueOfMinimum(int[] values)
        {
            int minimum = values[0];    // We start with values[0] as minimum

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < minimum)
                {
                    minimum = values[i];
                }
            }

            return minimum;
        }

        public static int ValueOfMinimumSmart(int[] values)
        {
            // Check
            if (values.Length == 0)
            {
                return Int32.MinValue;
            }

            int i = IndexOfMinimum(values);
            return values[i];
        }

        public static void Main(string[] args)
        {
            // Declare array + initialize with values
            int[] numbers = { 55, 33, 1, 88, 66 };

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write($"{numbers[i]} ");
            // }
            PrintNumbers(numbers);

            // Reset all numbers to zero
            // ResetNumbers(numbers);
            // PrintNumbers(numbers);

            Console.WriteLine($"The sum of numbers is: {SumOfNumbers(numbers)}");
            Console.WriteLine($"Minimum @ index {IndexOfMinimum(numbers)}");
            Console.WriteLine($"Value of Minimum {ValueOfMinimumSmart(numbers)}");

            // Special case !!!
            int[] empty = { };
            int sum = SumOfNumbers(empty);
            int minimum = ValueOfMinimumSmart(empty);

            // Create new array of size
            int[] otherNumbers = new int[10];
            // Create array of 10 integers


            // Create methode "RandomFunnyQuote"
            // Add code below in method
            // Generate random number
            // Return random quote
            string[] funnyQuotes = new string[10];
            funnyQuotes[0] = "Gentlemen, you can’t fight in here. This is the war room.";
        }
    }
}
