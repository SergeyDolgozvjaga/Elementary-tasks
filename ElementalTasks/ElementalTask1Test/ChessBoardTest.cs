using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTasks;

namespace ElementalTask1Test
{
    [TestClass]
    public class ChessBoardTest
    {
        [TestMethod]
        public void Width_Check_ValidTest()
        {
            int expectedWidth = 5;

            ChessBoard board = new ChessBoard(5, 6);      

            Assert.AreEqual(expectedWidth, board.Width);
        }

        [TestMethod]
        public void Heigth_Check_ValidTest()
        {
            int expectedHeigth = 6;

            ChessBoard board = new ChessBoard(5, 6);

            Assert.AreEqual(expectedHeigth, board.Height);
        }
    }
}
