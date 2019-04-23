using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask7;

namespace ElementalTask7Test
{
    [TestClass]
    public class NumericValidatorTest
    {
        [TestMethod]
        public void ArgumentValidator_0_100_Invalid_Number_Test()
        {
            bool expected = false;
            bool actual;

            int number = 0;
            int square = 100;
            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArgumentValidator_5001_100_Invalid_Number_Test()
        {
            bool expected = false;
            bool actual;

            int number = 5001;
            int square = 100;
            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArgumentValidator_100_0_Invalid_Square_Test()
        {
            bool expected = false;
            bool actual;

            int number = 100;
            int square = 0;
            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArgumentValidator_100_2147483648_Invalid_Square_Test()
        {
            bool expected = false;
            bool actual;

            int number = 100;
            int square = 2147483647;
            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArgumentValidator_0_0_Invalid_Number_And_Square_Test()
        {
            bool expected = false;
            bool actual;

            int number = 0;
            int square = 0;
            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArgumentValidator_10_15_Valid_Number_And_Square_Test()
        {
            bool expected = true;
            bool actual;

            int number = 10;
            int square = 15;
            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArgumentValidator_3_6000_Valid_Number_And_Square_Test()
        {
            bool expected = true;
            bool actual;

            int number = 3;
            int square = 6000;
            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(3, 50)]
        [DataRow(1, 300)]
        [DataRow(5, 7000)]
        [DataRow(10, 50500)]
        [DataRow(15, 888888)]
        [DataRow(325, 9999999)]
        public void ArgumentValidator_Valid_Number_And_Square_Test(int number, int square)
        {
            bool expected = true;
            bool actual;

            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, 50)]
        [DataRow(-3, 5)]
        [DataRow(-3, 7000)]
        [DataRow(-8, 300)]
        [DataRow(-699, 5000000)]
        [DataRow(-5, 8)]
        public void ArgumentValidator_Invalid_Number_Test(int number, int square)
        {
            bool expected = false;
            bool actual;

            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(50, 0)]
        [DataRow(3, -5)]
        [DataRow(3, -7000)]
        [DataRow(8, -300)]
        [DataRow(699, -5000000)]
        [DataRow(5, -8)]
        public void ArgumentValidator_Invalid_Square_Test(int number, int square)
        {
            bool expected = false;
            bool actual;

            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(-3, -5)]
        [DataRow(-3, -70)]
        [DataRow(-8, -300000)]
        [DataRow(-699, 0)]
        [DataRow(0, -3)]
        public void ArgumentValidator_Invalid_Number_And_Square_Test(int number, int square)
        {
            bool expected = false;
            bool actual;

            actual = NumericValidator.ArgumentValidator(number, square);

            Assert.AreEqual(expected, actual);
        }
    }
}
