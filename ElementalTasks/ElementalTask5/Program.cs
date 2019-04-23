using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            String answer = "";
            do
            {
                try
                {
                    Console.WriteLine("Enter your value from -999999999999999 to 999999999999999");
                    long inputValue = (long)Convert.ToDouble(Console.ReadLine());
                    if (NumberValidator.ValidateNumber(inputValue))
                    {
                        Words words = new Words(inputValue);
                        Console.WriteLine(words.RusWords());
                    }
                    ContinuePlayAsk();
                    answer = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format of input");
                    Console.WriteLine("It should be value from -999999999999999 to 999999999999999");
                }
            } while (Words.isContinue(answer));
        }

        private static void ContinuePlayAsk()
        {
            Console.WriteLine();
            Console.WriteLine("Do you want to play one more time?");
            Console.WriteLine("Answer 'yes' or 'y' to continue");
            Console.WriteLine("Any other key will stop the application");
        }
    }
}
