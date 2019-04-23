using System;

namespace ElementalTasks
{
    public class ChessBoardValidator
    {
        public static bool ValidatorChessBoard(int width, int height)
        {
            if (width <= 0)
            {
                Console.WriteLine("Width should be > 0");
                return false;
            }           

            if (height <= 0)
            {
                Console.WriteLine("Height value should be > 0");
                return false;
            }

            if ((width <= 0) && (height <= 0))
            {
                Console.WriteLine("Width and height value should be > 0");
                return false;
            }

            if (width > 240)
            {
                Console.WriteLine("Width should be not more than 240");
                return false;
            }

            if (height > 240)
            {
                Console.WriteLine("Height should be not more than 240");
                return false;
            }

            return true;
        }
    }
}
