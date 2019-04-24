using System;
using System.Collections.Generic;
using System.Text;

namespace ElementalTask9
{
    public class PalindromeCalculation
    {
        private void PrintPalindrome(IDictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> entry in dictionary)
            {
                Console.WriteLine(entry.Key);
            }
        }

        public void AddToDictionaryPalindrome(string input)
        {
            foreach (string word in input.Split(' '))
            {
                IDictionary<string, int> dictionary = new Dictionary<string, int>();
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
                            }
                        }
                    }
                }
                PrintPalindrome(dictionary);
            }
        }
    }
}

