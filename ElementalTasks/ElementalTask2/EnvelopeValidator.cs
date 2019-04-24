using System;

namespace ElementalTask2
{
    public class EnvelopeValidator
    {
        public static bool IsValidEnvelop(Envelope envelope)
        {
            if ((envelope.Width <= 0 || envelope.Width > 5000) 
                || (envelope.Heigth <= 0 || envelope.Heigth > 5000))
            {
                Console.WriteLine("Inserted sides should be higher than 0");
                Console.WriteLine("and less than 5000");
                return false;
            }
            return true;
        }


        public static bool IsContinue(string answer)
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
