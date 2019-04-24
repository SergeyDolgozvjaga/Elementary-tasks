using System;

namespace ElementalTask9
{
    public class PalindromeValidator
    {
        public static bool IsPalindrome(string inputString)
        {
            // empty string
            string reverseString = string.Empty;
            if (inputString != null)
            {
                // reverse string
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    reverseString += inputString[i].ToString();
                }

                // Compare reverse and input string
                if (reverseString == inputString && reverseString.Length >= 2)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsContinue(string answer)
        {
            if (answer.Equals("YES", StringComparison.OrdinalIgnoreCase)
                  || answer.Equals("Y", StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }
    }
}
