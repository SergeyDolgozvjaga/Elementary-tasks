using System;

namespace ElementalTask7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String continueAsk = "";
            PrintInfoAboutApp();
            do
            {
                try
                {
                    NumericOperations operations = new NumericOperations();
                    Console.WriteLine("Enter amount of numbers");
                    int numbersAmount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter square value");
                    double squareValue = Convert.ToDouble(Console.ReadLine());

                    // validates, if input numbersAmount and squareValue are correct 
                    if (NumericValidator.ArgumentValidator(numbersAmount, squareValue))
                    {
                        operations.PrintNumbers(operations.ValuesList(numbersAmount, squareValue));
                        
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unfortunatelly, inserted number is in the invalid number format" + "\n");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unfortunatelly, inserted number is too long" + "\n");
                }
                PrintInfoContinueGame();
                continueAsk = Console.ReadLine();
            } while (NumericValidator.IsContinue(continueAsk));
        }

        private static void PrintInfoAboutApp()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("Welcome to 'Numeric order' application");
            Console.WriteLine("**************************************");
            Console.WriteLine("How to use: ");
            Console.WriteLine("You must insert two digits to console");
            Console.WriteLine("First digit - amount of numbers");
            Console.WriteLine("it's distance between 1 and 5000");
            Console.WriteLine();
            Console.WriteLine("Second digit - square of number");
            Console.WriteLine("it's distance between 1 and 2000000000");
            Console.WriteLine("**************************************");
            Console.WriteLine("");
        }

        private static void PrintInfoContinueGame()
        {
            Console.WriteLine("Do you want to play one more time?");
            Console.WriteLine("Press 'y' or 'yes' to continue");
            Console.WriteLine("or press any other key to stop the application");
        }
    }
}
