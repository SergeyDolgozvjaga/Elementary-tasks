using System;

namespace ElementalTask4
{
    class PrintData
    {
        public static void PrintFindAndCountPattern()
        {
            try
            {
                Console.WriteLine("Input filename and string for find");
                Console.WriteLine("In type: <путь к файлу> <строка для подсчёта>");
                Console.ForegroundColor = ConsoleColor.Green;
                string inputData = Console.ReadLine();
                string[] partsInput = inputData.Split(' ');
                string fileName = partsInput[0];
                string stringPattern = partsInput[1];
                if (FileValidator.InputTwoParametersValidator(partsInput))
                {
                    int k = new File().CountStringPatternInFile(fileName, stringPattern);
                    Console.WriteLine(k);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unfortunatelly, inserted data isn't valid");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You should enter data in style: <путь к файлу> <строка для подсчёта>");
            }
        }


        public static void PrintReplacePattern()
        {
            try
            {
                Console.WriteLine("Input filename, string for find, string for replace");
                Console.WriteLine("In type: <путь к файлу> <строка для поиска> <строка для замены>");
                Console.ForegroundColor = ConsoleColor.Green;
                string inputData = Console.ReadLine();
                string[] partsInput = inputData.Split(' ');
                string fileName = partsInput[0];
                string stringPattern = partsInput[1];
                string stringReplace = partsInput[2];
                if (FileValidator.InputThreeParametersValidator(partsInput))
                {
                    int countReplaces = new File().ReplaceStringPatternInFile(fileName, stringPattern, stringReplace);
                    Console.Write("All words " + stringPattern + " replaces to " + stringReplace + " ");
                    Console.Write(countReplaces + " times");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unfortunatelly, inserted data isn't valid");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You should enter data in style: <путь к файлу> <строка для подсчёта>");
            }
        }
    }
}
