using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask3;

namespace ElementalTask3Test
{
    [TestClass]
    public class TriangleValidatorTest
    {
        [TestMethod]
        public void TriagleSizes_0_0_0_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(0, 0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriagleSizes_3000000_70000_500001_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(3000000, 70000, 500001);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriagleSizes_3_4_8_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(3, 4, 8);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriagleSizes_3_8_4_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(3, 8, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriagleSizes_7_2_4_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(7, 2, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriagleSizes_5_5_5_ValidTest()
        {
            bool expected = true;
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(5, 5, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsContinue_ValidTest()
        {
            bool expected = true;
            bool actual;

            actual = TriangleValidator.IsContinue("yes");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsContinue_InvalidTest()
        {
            bool expected = false;
            bool actual;

            actual = TriangleValidator.IsContinue("no");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(true, 3, 3, 4)]
        [DataRow(true, 5, 5, 6)]
        [DataRow(true, 7, 7, 6)]
        [DataRow(true, 11, 12, 9)]
        public void TriagleSizes_ValidTest(bool expected, double firstSize, double secondSize, double trirdSize)
        {
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(firstSize, secondSize, trirdSize);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]        
        [DataRow(false, 3, 8, 0)]
        [DataRow(false, 0, 0, 9)]
        [DataRow(false, 7, 2, 4)]
        [DataRow(false, 0, 5, 9)]
        public void TriagleSizes_InvalidTest(bool expected, double firstSize, double secondSize, double trirdSize)
        {
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(firstSize, secondSize, trirdSize);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(false, 700000, 8, 0000)]
        [DataRow(false, 50000, 600000, 900000)]
        [DataRow(false, 7000, 2000000, 4000000)]
        [DataRow(false, 0, 3453453, 9345345)]
        public void TriagleSizes_InvalidTest2(bool expected, double firstSize, double secondSize, double trirdSize)
        {
            bool actual;

            actual = TriangleValidator.IsValidSizeTriangle(firstSize, secondSize, trirdSize);
            Assert.AreEqual(expected, actual);
        }
    }
}
