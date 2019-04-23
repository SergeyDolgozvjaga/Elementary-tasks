using System;

namespace ElementalTask5
{
    public class Words
    {
        private String words;
        private long numValue;

        public Words()
        {
            this.words = "";
            this.numValue = 0;
        }

        public Words(long numValue)
        {
            this.words = "";
            this.numValue = numValue;
        }

        private long GetTrillion()
        {
            return numValue / ConstantValues.TRILLION;
        }

        private long GetBillion(long trillion)
        {
            return (numValue - (trillion * ConstantValues.TRILLION)) / ConstantValues.BILLION;
        }

        private long GetMillions(long trillion, long billion)
        {
            return (numValue - (trillion * ConstantValues.TRILLION) - (billion * ConstantValues.BILLION)) / ConstantValues.MILLION;
        }

        private long GetThousands(long trillion, long billion, long million)
        {
            return (numValue - (trillion * ConstantValues.TRILLION) - (billion * ConstantValues.BILLION)
                    - (million * ConstantValues.MILLION)) / 1000;
        }

        private int GetHundreds(long numericalValue)
        {
            return (int)numericalValue / 100;
        }

        private int GetDecimals(long numericalValue, int hundreds)
        {
            return (int)(numericalValue - (hundreds * 100)) / 10;
        }

        private int GetUnits(long numericalValue)
        {
            return (int)numericalValue % 10;
        }

        public string RusWords()
        {
            long tempValue = numValue;
            if (numValue < 0)
            {
                words = "минус ";
                numValue = -tempValue;
            }
            long trillion = GetTrillion();
            long billion = GetBillion(trillion);
            long million = GetMillions(trillion, billion);
            long thousand = GetThousands(trillion, billion, million);
            long digits = numValue % 1000;
            words = words + WordsToThousand(trillion, 0)
                    + WordsToThousand(billion, 1)
                    + WordsToThousand(million, 2)
                    + WordsToThousand(thousand, 3)
                    + WordsToThousand(digits, 4);
            return words.Trim().Replace("\\s+", " ");
        }

        private String WordsToThousand(long numericalValue, int index)
        {
            String returnedValue = "";
            int indexA;
            int hundreds = GetHundreds(numericalValue);
            int decimale = GetDecimals(numericalValue, hundreds);
            int units = GetUnits(numericalValue);

            if (decimale == 1)
            {
                returnedValue = ConstantValues.HUNDREDS[hundreds] + ConstantValues.NUMBERS10TO19[units];
            }
            else
            {
                returnedValue = ConstantValues.HUNDREDS[hundreds] 
                    + ConstantValues.DECIMALS[decimale] 
                    + ConstantValues.UNITS[units];
            }

            if (index == 3)
            {
                returnedValue = ThousandsDeclination(returnedValue, units, decimale);
            }
            else
            {
                returnedValue = AnotherDeclination(returnedValue, units, decimale);
            }

            indexA = GetIndexByValues(numericalValue, units, decimale);

            returnedValue += " " + GetTextMillion(indexA, index);
            return returnedValue;
        }

        public static bool isContinue(string answer)
        {
            if (answer.Equals("YES", StringComparison.OrdinalIgnoreCase)
                || answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }

        private string GetTextMillion(int a, int index)
        {
            string returnValue = "";
            switch (a)
            {
                case 0: returnValue = ConstantValues.THOUSANS_TO_TRILLIONS_EMPTY[index]; break;
                case 1: returnValue = ConstantValues.THOUSANS_TO_TRILLIONS_OV[index]; break;
                case 2: returnValue = ConstantValues.THOUSANS_TO_TRILLIONS_ON[index]; break;
                case 3: returnValue = ConstantValues.THOUSANS_TO_TRILLIONS_ONA[index]; break;
                case 4: returnValue = ConstantValues.THOUSANS_TO_TRILLIONS_OVV[index]; break;
                default: return "";
            }
            return returnValue;
        }

        private string ThousandsDeclination(String returnedValue, int units, int decimale)
        {
            if (units == 1 && decimale != 1)
            {
                returnedValue += "на ";
            }
            else if (units == 2 & decimale != 1)
            {
                returnedValue += "е ";
            }
            if (units > 1 && decimale != 1)
            {
                returnedValue += " ";
            }
            return returnedValue;
        }

        private string AnotherDeclination(String returnedValue, int units, int decimale)
        {
            if (units == 1 && decimale != 1)
            {
                returnedValue += "ин ";
            }
            else if (units == 2 & decimale != 1)
            {
                returnedValue += "а ";
            }
            else if (units != 0 & decimale != 1)
            {
                returnedValue += " ";
            }
            return returnedValue;
        }

        private int GetIndexByValues(long numericalValue, int units, int decimale)
        {
            int indexA = 0;
            if (numericalValue != 0)
            {
                if (units == 0 || decimale == 1)
                {
                    indexA = 1;
                }
                else if (units == 1)
                {
                    indexA = 2;
                }
                else if (units < 5)
                {
                    indexA = 3;
                }
                else
                {
                    indexA = 4;
                }
            }
            return indexA;
        }
    }
}
