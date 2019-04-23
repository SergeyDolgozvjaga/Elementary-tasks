using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTasks;

namespace ElementalTask1Test
{
    [TestClass]
    public class ChessBoardValidatorTest
    {
        [TestMethod]
        public void Width_0_Height_10_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = ChessBoardValidator.ValidatorChessBoard(0, 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Width_15_Height_0_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = ChessBoardValidator.ValidatorChessBoard(15, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Width_0_Height_0_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = ChessBoardValidator.ValidatorChessBoard(0, 0);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LessZero_Width_Heigth_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = ChessBoardValidator.ValidatorChessBoard(-3, -5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Width_241_Height_20_Boundary_Width_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = ChessBoardValidator.ValidatorChessBoard(241, 20);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Width_20_Height_241_Boundary_Height_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = ChessBoardValidator.ValidatorChessBoard(20, 241);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Width_5_Height_3_ValidTest()
        {
            bool expected = true;
            bool actual;

            actual = ChessBoardValidator.ValidatorChessBoard(5, 3);

            Assert.AreEqual(expected, actual);
        }
    }
}
