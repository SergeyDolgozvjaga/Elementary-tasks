using System;

namespace ElementalTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbersArray = new Numbers().GetNumbers();
                PrintResults(new Tickets(numbersArray[0], numbersArray[1]));
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Value can be only numbers from 100000 to 999999");
                Console.ReadKey();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Max value should be more, than min value");
                Console.ReadKey();
            }            
        } 

        private static void PrintResults(Tickets tickets)
        {
            int hardCount = tickets.GetHardCount();
            int easyCount = tickets.GetEasyCount();

            if (hardCount > easyCount)
            {
                Console.WriteLine("HardCount defines more on this arrange than EasyCount");
                Console.WriteLine("HardCount: " + hardCount + " EasyCount: " + easyCount);
            }
            else if (easyCount > hardCount)
            {
                Console.WriteLine("EasyCount defines more on this arrange than HardCount");
                Console.WriteLine("EasyCount: " + easyCount + " HardCount: " + hardCount);
            }
            else
            {
                Console.WriteLine("They are defines the same times: " + hardCount + " : " + easyCount);
            }
        }
    }
}
