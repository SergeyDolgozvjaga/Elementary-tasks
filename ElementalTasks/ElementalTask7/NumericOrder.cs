using System;
using System.Collections;

namespace ElementalTask7
{
    public class NumericOrder
    {
        // length of numbers row 
        private int length;

        // square of number
        private double square;

        public NumericOrder()
        {
            // init length and square with default values
            length = 0;
            square = 0;
        }

        public NumericOrder(int length, double square)
        {
            this.length = length;
            this.square = square;
        }

        public ArrayList GetNumericOrder()
        { 
        
            if ((length == 0) && (square == 0))
            {
                return null;
            }

            ArrayList numbersList = new ArrayList();

            int firstNumber = (int)Math.Sqrt(square) + 1;

            int n = 0;  // counter, how many numbers add to arraylist, counts from 0

            for (int i = firstNumber; n < length; n++)
            {
                numbersList.Add(i + n);
            }
            return numbersList;
        }
    }
}
