using System;
using System.Collections.Generic;

namespace ElementalTask8
{
    class Fibonacci
    {
        // get all numbers in diapazone fromm start to end
        public List<long> GetNumbersInRange(long start, long end)
        {
            List<long> values = new List<long>();
            long[] loopValues = FibonacciOperations.GetRangeOfPositions(start, end);
            for (long i = loopValues[0]; i < loopValues[1]; i++)
            {
                if ((GetNumber(i) > start) && (GetNumber(i) < end))
                {
                    values.Add(GetNumber(i));
                }
            }
            return values;
        }

        // get all numbers if input length
        public List<long> GetNumbersInLength(long length)
        {
            List<long> returnedValues = new List<long>();
            long minLength = FibonacciOperations.GetNumbersPositionByLength(length);
            long maxLength = FibonacciOperations.GetNumbersPositionByLength(length + 1);
            for (long i = minLength; i < maxLength; i++)
            {
                returnedValues.Add(GetNumber(i));
            }
            return returnedValues;
        }

        // how calculate a number
        private long GetNumber(long n)
        {
            double a = Math.Pow(1 + (Math.Pow(5, 0.5)), n);
            double b = Math.Pow((1 - Math.Pow(5, 0.5)), n);
            double c = Math.Pow(2, n) * Math.Pow(5, 0.5);

            return (long)Math.Round((a - b) / c);
        }
    }
}
