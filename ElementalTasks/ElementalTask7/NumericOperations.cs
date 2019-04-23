using System;
using System.Collections;

namespace ElementalTask7
{
    public class NumericOperations
    {
        public ArrayList ValuesList(int numbers, int square)
        {
            NumericOrder numericOrder = new NumericOrder(numbers, square);
            ArrayList listValues = numericOrder.GetNumericOrder();
            return listValues;
        }
        public void PrintInfoAboutApp()
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
            Console.WriteLine("it's distance between 1 and 2147483646");
            Console.WriteLine("**************************************");
            Console.WriteLine("");          
        }

        public void PrintNumbers(ArrayList listOfValues)
        {
            Console.Write("Output numbers: ");

            string output = "";
            
            foreach (int i in listOfValues)
            {
                output += i + ",";               
            }
            string removeLastComma = output.Remove(output.Length - 1);
            // print all numbers
            Console.Write(removeLastComma);
            Console.ReadKey();
        }
    }
}
