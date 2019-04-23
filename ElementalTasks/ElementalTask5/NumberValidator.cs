using System;

namespace ElementalTask5
{
    class NumberValidator
    {        
        public static bool ValidateNumber(long input)
        {
            if (input == 0) return false;
            if (input < -ConstantValues.MAX_VALUE || input > ConstantValues.MAX_VALUE)
            {
                Console.WriteLine("Число выходит за рамки указанного диапазона");
                return false;
            }
                      
            return true;
        }
    }
}
