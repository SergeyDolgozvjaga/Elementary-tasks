using System;

namespace ElementalTask2
{
    public class EnvelopeCalculation
    {
        public void PrintEnvelopeInputResult(Envelope envelop1, Envelope envelop2)
        {
            Console.WriteLine(EnvelopeCheck(envelop1, envelop2));
        }

        public static void PrintIsContinue()
        {
            Console.WriteLine("Would you like to continue?");
            Console.WriteLine("For continue press 'yes' or 'y'");
            Console.WriteLine("Any other key will stop application");
        }

        public string EnvelopeCheck(Envelope envelop1, Envelope envelop2)
        {
            if (envelop2.Width < envelop1.Width && envelop2.Heigth < envelop1.Heigth)
            {
                return "You can put Envelope2 in Envelope1";
            }
            else if (envelop1.Width < envelop2.Width && envelop1.Heigth < envelop2.Heigth)
            {
                return "You can put Envelope1 in Envelope2";
            }
            else
            {
                return "You cannot put one envelope to another.";
            }
        }
    }
}
