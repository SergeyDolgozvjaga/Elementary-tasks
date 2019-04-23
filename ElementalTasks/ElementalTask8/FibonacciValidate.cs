using System;

namespace ElementalTask8
{
    class FibonacciValidate
    {
        public static bool ValidateValues(long min, long max)
        {
            if ((min < 0) || (max <= 0))
            {
                Console.WriteLine("Min or max value should be > 0");
                return false;
            }
            if (min > max)
            {
                Console.WriteLine("Min value can't be bigger than max value");
                return false;
            }
            return true;
        }
        

        public static bool ValidateLength(long length)
        {
            if (length <= 0) {
                Console.WriteLine("Length should be bigger than 0");
                return false;
            }
            return true;
        }

        public static bool IsValidateVesrionChoose(String answer)
        {
            if (answer.Equals("1", StringComparison.OrdinalIgnoreCase)
                || answer.Equals("2", StringComparison.OrdinalIgnoreCase))
            { 
                return true;
            }

            Console.WriteLine("Your input is incorrect");
            return false;
        }
    }
}
