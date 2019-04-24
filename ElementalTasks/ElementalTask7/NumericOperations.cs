using System;
using System.Collections;

namespace ElementalTask7
{
    public class NumericOperations
    {
        public ArrayList ValuesList(int numbers, double square)
        {
            NumericOrder numericOrder = new NumericOrder(numbers, square);
            ArrayList listValues = numericOrder.GetNumericOrder();
            return listValues;
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
            Console.WriteLine("\n");
        }
    }
}
