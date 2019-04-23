using System;

namespace ElementalTask7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                NumericOperations operations = new NumericOperations();
                operations.PrintInfoAboutApp();

                Console.WriteLine("Enter amount of numbers");
                int numbersAmount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter square value");
                int squareValue = Convert.ToInt32(Console.ReadLine());

                // validates, if input numbersAmount and squareValue are correct 
                if (NumericValidator.ArgumentValidator(numbersAmount, squareValue))
                {
                    operations.PrintNumbers(operations.ValuesList(numbersAmount, squareValue));
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unfortunatelly, inserted number is in the invalid number format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unfortunatelly, inserted number is very long");
            }
        }
    }
}
