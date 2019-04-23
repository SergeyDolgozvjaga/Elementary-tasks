using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTask9
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                PrintInfo();
                Console.WriteLine("Please input a number...");
                string userInput = Console.ReadLine();
                string[] splitInput = userInput.Split(' ');
                PalindromeCalculation palindromeCalc = new PalindromeCalculation();
                PrintPalindrome(palindromeCalc.AddToDictionary(splitInput));              
            }
            catch (FormatException)
            {
                Console.WriteLine("Unfortunatelly, inserted number is in the invalid number format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unfortunatelly, inserted number is too long");
            }
        }

        public static void PrintInfo()
        {
            Console.WriteLine("Welcome to our Palindrome application");
            Console.WriteLine("app check if input number or it's part");
            Console.WriteLine("is a palindrome");
            Console.WriteLine("--------------------------------------");                 
        }

        public static void PrintPalindrome(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                Console.WriteLine(entry.Key);
            }
        }
    }
}
