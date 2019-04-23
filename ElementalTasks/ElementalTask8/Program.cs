using System;

namespace ElementalTask8
{
    class Program
    {
        
        static void Main(string[] args)
        {
            WelcomeInfo();
            Console.WriteLine("please press '1' or '2' to choose way you want to use");
            string versionChoose = Console.ReadLine();

            if (FibonacciValidate.IsValidateVesrionChoose(versionChoose))
            {
                switch (versionChoose)
                {
                    case "1":
                        new FibonacciOperations().PrintNumbersLengthInput();
                        break;
                    case "2":
                        new FibonacciOperations().PrintNumbersTwoNumbersInput();
                        break;
                    default:
                        Console.WriteLine("Incorrect input for version choose");
                        break;
                }
            }
        }

        private static void WelcomeInfo()
        {
            Console.WriteLine("Welcome to 'Fibonacci application'");
            Console.WriteLine("**********************************");
            Console.WriteLine("application has two versions of work:");
            Console.WriteLine();
            Console.WriteLine("version1: you input 1 number");
            Console.WriteLine("this number is a length of numbers, that will print");
            Console.WriteLine();
            Console.WriteLine("version 2: you input 2 numbers in range");
            Console.WriteLine("first number is from (min) , and second number is to (max)");
            Console.WriteLine("max should be more than min");
            Console.WriteLine();
        }
    }
}
