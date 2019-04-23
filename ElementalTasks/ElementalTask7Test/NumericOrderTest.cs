using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask7;
using System.Collections;

namespace ElementalTask7Test
{
    [TestClass]
    public class NumericOrderTest
    {
        [TestMethod]
        public void GetNumbersOrderContains_11_Test()
        {
            int expected = 11;
            ArrayList actualCollection;

            NumericOrder order = new NumericOrder(8, 100);
            actualCollection = order.GetNumericOrder();

            CollectionAssert.Contains(actualCollection, expected);
        }

        [TestMethod]
        public void GetNumbersOrderCheckTest()
        {
            int expected = 8;
            int actual;

            NumericOrder order = new NumericOrder(8, 100);
            ArrayList orderList = order.GetNumericOrder();
            actual = orderList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 5, 20)]
        [DataRow(3, 3, 8)]
        [DataRow(20, 20, 380)]
        [DataRow(15, 10, 224)]
        [DataRow(300, 30, 89900)]
        [DataRow(500, 50, 249090)]
        public void GetNumbersOrderContainsTest(int expected, int length, int square)
        {
            ArrayList actualCollection;

            NumericOrder order = new NumericOrder(length, square);
            actualCollection = order.GetNumericOrder();

            CollectionAssert.Contains(actualCollection, expected);
        }

        [TestMethod]
        [DataRow(5, 5, 200)]
        [DataRow(3, 3, 1000)]
        [DataRow(20, 20, 20)]
        [DataRow(300, 300, 5000)]
        [DataRow(5000, 5000, 100)]
        [DataRow(1050, 1050, 1050)]
        public void GetNumbersOrderLengthTest(int expected, int length, int square)
        {
            int actual;

            NumericOrder order = new NumericOrder(length, square);
            ArrayList orderList = order.GetNumericOrder();
            actual = orderList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
