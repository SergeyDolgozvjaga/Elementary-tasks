using System;

namespace ElementalTask2
{
    class EnvelopeValidator
    {
        public static bool isValidEnvelop(double width, double heigth)
        {
            if (width <= 0 || heigth <= 0)
            {
                Console.WriteLine("Inserted sides should be higher than 0");
                Console.ReadKey();
                return false;
            }
            return true;
        }
        public static bool isContinue(string answer)
        {
            if (answer.Equals("YES", StringComparison.OrdinalIgnoreCase)
                || answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
