using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask3;

namespace ElementalTask3Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void GetNameTest()
        {
            string expected = "triangle";
            string actual;

            Triangle triangle = new Triangle("triangle", 7, 7, 7);
            actual = triangle.Name;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetFirstSideTest()
        {
            double expected = 7;
            double actual;

            Triangle triangle = new Triangle("triangle", 7, 7, 7);
            actual = triangle.FirstSide;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSecondSideTest()
        {
            double expected = 8;
            double actual;

            Triangle triangle = new Triangle("triangle", 8, 8, 8);
            actual = triangle.SecondSide;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetThirdSideTest()
        {
            double expected = 4;
            double actual;

            Triangle triangle = new Triangle("triangle", 4, 4, 4);
            actual = triangle.ThirdSide;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSquareTest()
        {
            string expected = "6,93";
            string actual;

            Triangle triangle = new Triangle("triangle", 4, 4, 4);
            actual = triangle.GetSquare().ToString("##.##");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("4,47", "triangle1", 3, 3, 4)]
        [DataRow("12", "triangle2", 5, 5, 6)]
        [DataRow("18,97", "triangle3", 7, 7, 6)]
        [DataRow("47,33", "triangle4", 11, 12, 9)]
        public void Get_Square_Test(string expected, string name,
            double firstSize, double secondSize, double trirdSize)
        {
            string actual;

            Triangle triangle = new Triangle(name, firstSize, secondSize, trirdSize);
            actual = triangle.GetSquare().ToString("##.##");

            Assert.AreEqual(expected, actual);
        }
    }
}
