using System;

namespace ElementalTask7
{
    public class NumericValidator
    {
        public static bool ArgumentValidator(int numbersAmount, int squareValue)
        {
            if (numbersAmount <= 0 || numbersAmount > 5000)
            {
                Console.WriteLine("Numbers amount should be > 0");
                return false;
            }

            if (squareValue <= 0 || squareValue > 2147483646)
            {
                Console.WriteLine("Square value should be > 0");
                return false;
            }

            if(numbersAmount <= 0 && squareValue <= 0)
            {
                Console.WriteLine("Numbers and square values should be > 0");
                return false;
            }

            return true;
        }
    }
}
