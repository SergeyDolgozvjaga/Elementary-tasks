using System;
using System.Collections.Generic;

namespace ElementalTask8
{
    class FibonacciOperations
    {
        Fibonacci number = new Fibonacci();

        // count how many digits in number
        private static int GetCountsOfDigits(long num)
        {
            int count = 0;
            while (num != 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }

        // count range of number 'start' and ranger of number 'end'
        public static long[] GetRangeOfPositions(long start, long end)
        {
            long[] returnedValues = new long[2];
            int startPosition = FibonacciOperations.GetCountsOfDigits(start);
            int endPosition = FibonacciOperations.GetCountsOfDigits(end);
            returnedValues[0] = FibonacciOperations.GetNumbersPositionByLength(startPosition);
            returnedValues[1] = FibonacciOperations.GetNumbersPositionByLength(endPosition + 1);
            return returnedValues;
        }

        // how many numbers will be if input length
        public static int GetNumbersPositionByLength(long length)
        {
            int returnedValue = 0;
            for (int i = 1; i < length; i++)
            {
                if (i == 1)
                {
                    returnedValue += 7;
                }
                else if (i % 4 != 0)
                {
                    returnedValue += 5;
                }
                else
                {
                    returnedValue += 4;
                }
            }
            return returnedValue;
        }

        public void PrintNumbersLengthInput()
        {
            try
            {
                FibonacciOperations operations = new FibonacciOperations();
                Console.WriteLine("Input length...");
                long length = (long)Convert.ToDouble(Console.ReadLine());
                if (FibonacciValidate.ValidateLength(length))
                {
                    operations.PrintNumbers(length);
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, but input length isn't correct");
                Console.ReadKey();
            }
        }

        public void PrintNumbersTwoNumbersInput()
        {
            try
            {
                FibonacciOperations operations = new FibonacciOperations();
                Console.WriteLine("Input first value");
                long minValue = (long)Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input second value");
                long maxValue = (long)Convert.ToDouble(Console.ReadLine());

                if (FibonacciValidate.ValidateValues(minValue, maxValue))
                {
                    operations.PrintNumbers(minValue, maxValue);
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, but input values aren't correct");
                Console.ReadKey();
            }
        }

        private void PrintNumbers(long length)
        {
            List<long> valuesInLength = number.GetNumbersInLength(length);
            foreach (long num in valuesInLength)
            {
                Console.WriteLine(num);
            }
        }

        private void PrintNumbers(long firstValue, long secondValue)
        {
            List<long> valuesInDiapason = number.GetNumbersInRange(firstValue, secondValue);

            foreach (long num in valuesInDiapason)
            {
                Console.WriteLine(num);
            }      
        }
    }
}
