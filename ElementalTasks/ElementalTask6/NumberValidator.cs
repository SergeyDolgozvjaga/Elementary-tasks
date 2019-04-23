using System;

namespace ElementalTask6
{
    class NumberValidator
    {
        public static bool ValidateNumber(int number)
        {
            string numberLengthCheck = number.ToString();
            if (numberLengthCheck.Length == Tickets.COUNT_OF_DIGITS) return true;               
            throw new FormatException("Value can be only numbers from 000001 to 999999");
        }

        public static bool MaxMoreThanMinCheck(int min, int max)
        {
            if (min < max) return true;
            throw new ArgumentException("Max value should be more, than min value");
        }
    }
}
