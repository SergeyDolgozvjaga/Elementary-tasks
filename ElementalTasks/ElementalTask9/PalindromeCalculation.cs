using System;
using System.Collections.Generic;
using System.Text;

namespace ElementalTask9
{
    public class PalindromeCalculation
    {
        public Dictionary<string, int> AddToDictionary(string[] splitInput)
        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string word in splitInput)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int j = i; j < word.Length; j++)
                    {
                        stringBuilder.Append(word[j]);
                        string forming = stringBuilder.ToString();
                        if (PalindromeValidator.IsPalindrome(forming))
                        {
                            if (!dictionary.ContainsKey(forming))
                            {
                                dictionary.Add(forming, j);
                                return dictionary;
                            }
                        }
                    }
                }
            }
            return dictionary;
        }

        public void PrintPalindrome(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                Console.WriteLine(entry.Key);
            }
        }
    }
}

