using System;

namespace ElementalTask7
{
    public class NumericValidator
    {
        public static bool ArgumentValidator(int numbersAmount, double squareValue)
        {
            if ((numbersAmount <= 0 || numbersAmount > 5000) 
                && (squareValue <= 0 || squareValue > 2000000000))
            {
                Console.WriteLine("Numbers amount should be > 0 and less then 5000");
                Console.WriteLine("Square value should be > 0 and less then 2000000000" + "\n");
                return false;
            }

            if (numbersAmount <= 0 || numbersAmount > 5000)
            {
                Console.WriteLine("Numbers amount should be > 0 and less then 5000" + "\n");
                return false;
            }

            if (squareValue <= 0 || squareValue > 2000000000)
            {
                Console.WriteLine("Square value should be > 0 and less then 2000000000" + "\n");
                return false;
            }
            return true;
        }

        public static bool IsContinue(string answer)
        {
            if (answer.Equals("YES", StringComparison.OrdinalIgnoreCase)
                  || answer.Equals("Y", StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
    }
}
