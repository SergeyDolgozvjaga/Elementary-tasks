using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementalTask6
{
    class Tickets
    {
        public const int COUNT_OF_DIGITS = 6;

        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }

        public Tickets()
        {
        }

        public Tickets(int minNumber, int maxNumber)
        {
            MinNumber = minNumber;
            MaxNumber = maxNumber;
        }

        public int GetEasyCount()
        {
            int count = 0;
            for (int i = MinNumber; i <= MaxNumber; i++)
            {
                int tempValue = i;
                int firstSum = 0;
                int secondSum = 0;
                for (int j = 0; j < COUNT_OF_DIGITS; j++)
                {
                    if (j > 3)
                    {
                        firstSum += (tempValue % 10);
                        tempValue /= 10;
                    }
                    else
                    {
                        secondSum += (tempValue % 10);
                        tempValue /= 10;
                    }
                }
                if (secondSum == firstSum)
                {
                    count++;
                }
            }
            return count;
        }

        public int GetHardCount()
        {
            int count = 0;
            for (int i = MinNumber; i <= MaxNumber; i++)
            {
                int tempValue = i;
                int firstSum = 0;
                int secondSum = 0;
                for (int j = 0; j < COUNT_OF_DIGITS; j++)
                {
                    if (j % 2 == 0)
                    {
                        firstSum += tempValue % 10;
                        tempValue /= 10;
                    }
                    else
                    {
                        secondSum += tempValue % 10;
                        tempValue /= 10;
                    }
                }
                if (secondSum == firstSum)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
