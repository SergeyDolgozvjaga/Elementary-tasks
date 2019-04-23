using System;

namespace ElementalTask4
{
    class Program
    {
        public static void Main(string[] args)
        {
            PrintInfo();
            Console.WriteLine("Input '1' or '2'...");
            string chooseOption = Console.ReadLine();       

            switch (chooseOption)
            {
                case "1": PrintData.PrintFindAndCountPattern(); break;
                case "2": PrintData.PrintReplacePattern(); break;
                default: Console.WriteLine("Incorrect input"); break;
            }
            Console.ReadKey();
        }

        public static void PrintInfo()
        {
            Console.WriteLine("Welcome to our application");
            Console.WriteLine("Please insert '1' or '2' to choose");
            Console.WriteLine("what will application do");
            Console.WriteLine();
            Console.WriteLine("Press '1' if you want to count how many times");
            Console.WriteLine("word, that you will choose repeat in file");
            Console.WriteLine();
            Console.WriteLine("Press '2' if you want replace all words in file");
            Console.WriteLine("that will match with your word");
            Console.WriteLine();
        } 
    }
}
