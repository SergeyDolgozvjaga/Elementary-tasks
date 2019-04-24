using System;

namespace ElementalTask2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string answer = "";
            do
            {
                try
                {
                    Console.WriteLine("Envelop #1. Please, write width, heigth");
                    Console.WriteLine("Enter a width of first envelope...");
                    double widthFirst = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter a heigth of first envelope...");
                    double heigthFirst = Convert.ToDouble(Console.ReadLine());
                    Envelope envelope1 = new Envelope(widthFirst, heigthFirst);
                    Console.WriteLine("Envelop #2. Please, write width, heigth");
                    Console.WriteLine("Enter a width of second envelope...");
                    double widthSecond = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter a heigth of second envelope...");
                    double heigthSecond = Convert.ToDouble(Console.ReadLine());
                    Envelope envelope2 = new Envelope(widthSecond, heigthSecond);

                    if (EnvelopeValidator.IsValidEnvelop(envelope1)
                    && EnvelopeValidator.IsValidEnvelop(envelope2))
                    {
                        new EnvelopeCalculation().PrintEnvelopeInputResult(envelope1, envelope2);
                        Console.ReadKey();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect input!");
                    Console.ReadKey();
                }
                EnvelopeCalculation.PrintIsContinue();
                answer = Console.ReadLine();
                
            } while (EnvelopeValidator.IsContinue(answer)); 
        }       
    }
}
