using System;

namespace ElementalTasks
{
    public class ChessBoard
    {
        // black andwhite square in ascii-code
        private const string whiteSquare = "\u25A1";
        private const string blackSquare = "\u25A0";

        private int width;
        private int height;

        public int Width { get; set; }
        public int Height { get; set; }

        public ChessBoard(int width, int height)
        {
            Width = width;
            Height = height;
        }

        // get current chessboard
        public void GetChessBoard()
        {
            for (int row = 0; row < width; row++) 
            {
                for (int col = 0; col < height; col++) 
                {
                    if ((row + col) % 2 == 0)  //Check if cells is even
                    {
                        Console.Write(whiteSquare); 
                    }
                    else
                    {
                        Console.Write(blackSquare); 
                    }
                }
                Console.WriteLine(); 
            }
        }
    }
}
