using System;

namespace ElementalTask3
{
    public class TriangleValidator
    {
        public static bool IsValidSizeTriangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                Console.WriteLine("Insert numbers should be more, than 0");
                return false;
            }
            else if (((firstSide + secondSide) <= thirdSide) 
                 || ((firstSide + thirdSide) <= secondSide)
                 || ((secondSide + thirdSide) <= firstSide))
            {
                Console.WriteLine("Insert numbers do not meet the conditions ");
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
