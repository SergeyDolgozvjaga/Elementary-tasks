using System;

namespace ElementalTask6
{
    class Numbers
    {
        public int[] GetNumbers()
        {
            int[] numbers = new int[2];
            Console.WriteLine("Enter min value");
            int minValue = Convert.ToInt32(Console.ReadLine());
            if (NumberValidator.ValidateNumber(minValue))
            {
                numbers[0] = minValue;
            }
            Console.WriteLine("Enter max value");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            if (NumberValidator.ValidateNumber(maxValue))
            {
                numbers[1] = maxValue;
            }
            NumberValidator.MaxMoreThanMinCheck(numbers[0], numbers[1]);
            return numbers;
        }         
    }
}
