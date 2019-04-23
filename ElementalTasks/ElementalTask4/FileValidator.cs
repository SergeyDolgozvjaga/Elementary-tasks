using System;

namespace ElementalTask4
{
    class FileValidator
    {
        public static bool InputTwoParametersValidator(string[] input)
        {
            if (input.Length == 2) return true;
            Console.WriteLine("You input incorrect number of values");
            return false;
        }

        public static bool InputThreeParametersValidator(string[] input)
        {
            if (input.Length == 3) return true;
            Console.WriteLine("You input incorrect number of values");
            return false;
        }
    }
}
