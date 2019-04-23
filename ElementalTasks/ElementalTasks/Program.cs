using System;

namespace ElementalTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to 'Chessboard' applicaton");
                Console.WriteLine("Enter width value");
                int widthNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter heigth value");
                int heigthNumber = Convert.ToInt32(Console.ReadLine());

                if (ChessBoardValidator.ValidatorChessBoard(widthNumber, heigthNumber))
                {
                    Console.WriteLine("Printing chessboard...");
                    ChessBoard chessBoard = new ChessBoard(widthNumber, heigthNumber);
                    chessBoard.GetChessBoard();
                    Console.ReadKey();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unfortunatelly, inserted number is in the invalid number format");                
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unfortunatelly, inserted number is very long"); 
            }       
        }
    }
}
