using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask7;
using System.Collections;

namespace ElementalTask7Test
{
    [TestClass]
    public class NumericOperationsTest
    {
        [TestMethod]
        public void ValuesListLengthCheckTest()
        {
            int expected = 5;
            int actual;

            NumericOperations operations = new NumericOperations();
            ArrayList listValues = operations.ValuesList(5, 200);
            actual = listValues.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValuesListContains_8_Test()
        {
            int expected = 8;
            ArrayList actualCollection;

            NumericOperations operations = new NumericOperations();
            actualCollection = operations.ValuesList(3, 49);

            CollectionAssert.Contains(actualCollection, expected);
        }

        [TestMethod]
        public void ValuesListEqualCollectionTest()
        {
            ArrayList expected = new ArrayList();
            expected.Add(5);
            expected.Add(6);
            expected.Add(7);
            ArrayList actual;

            NumericOperations operations = new NumericOperations();
            actual = operations.ValuesList(3, 16);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValuesListNotEqualCollectionTest()
        {
            ArrayList expected = new ArrayList();
            expected.Add(5);
            expected.Add(6);
            expected.Add(7);
            ArrayList actual;

            NumericOperations operations = new NumericOperations();
            actual = operations.ValuesList(3, 36);

            CollectionAssert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 5, 200)]
        [DataRow(3, 3, 1000)]
        [DataRow(20, 20, 20)]
        [DataRow(300, 300, 5000)]
        [DataRow(5000, 5000, 100)]
        [DataRow(1050, 1050, 1050)]
        public void ValuesList_Length_Check_Test(int expected, int length, int square)
        {
            
            int actual;

            NumericOperations operations = new NumericOperations();
            ArrayList listValues = operations.ValuesList(length, square);
            actual = listValues.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 5, 20)]
        [DataRow(3, 3, 8)]
        [DataRow(20, 20, 380)]
        [DataRow(15, 10, 224)]
        [DataRow(300, 30, 89900)]
        [DataRow(500, 50, 249090)]
        public void ValuesList_Contains_Number_Test(int expected, int length, int square)
        {
            ArrayList actualCollection;

            NumericOperations operations = new NumericOperations();
            actualCollection = operations.ValuesList(length, square);

            CollectionAssert.Contains(actualCollection, expected);
        }
    }
}
