using System;

namespace ElementalTask9
{
    public class Program
    {
        public static void Main()
        {
            String continueAsk = "";
            PrintInfo();
            do
            {
                try
                {
                    Console.WriteLine("Please input a number...");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string userInput = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;

                    new PalindromeCalculation().AddToDictionaryPalindrome(userInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input value is incorrect");
                }

                PrintInfoContinue();
                Console.ForegroundColor = ConsoleColor.Green;
                continueAsk = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

            } while (PalindromeValidator.IsContinue(continueAsk));
        }

        public static void PrintInfo()
        {
            Console.WriteLine("Welcome to our Palindrome application");
            Console.WriteLine("app check if input number or it's part");
            Console.WriteLine("is a palindrome");
            Console.WriteLine("--------------------------------------");
        }

        private static void PrintInfoContinue()
        {
            Console.WriteLine("Do you want to play one more time?");
            Console.WriteLine("Press 'y' or 'yes' to continue");
            Console.WriteLine("or press any other key to stop");
        }
    }
}
