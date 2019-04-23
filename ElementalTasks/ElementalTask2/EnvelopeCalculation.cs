using System;

namespace ElementalTask2
{
    class EnvelopeCalculation
    {
        public static void envelopeCalculate(Envelope envelop1, Envelope envelop2)
        {
            if (envelop2.Width < envelop1.Width && envelop2.Heigth < envelop2.Heigth)
            {
                Console.WriteLine("You can put Envelope2 in Envelope1");
            }
            else if (envelop1.Width < envelop2.Width && envelop1.Heigth < envelop2.Heigth)
            {
                Console.WriteLine("You can put Envelope1 in Envelope2");
            }
            else
            {
                Console.WriteLine("You cannot put one envelope to another.");
            }
        }
    }
}
