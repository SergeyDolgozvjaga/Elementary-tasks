using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
