using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElementalTask3;

namespace ElementalTask3Test
{
    [TestClass]
    public class TriangleOperationsTest
    {
        [TestMethod]
        public void DescendingSortTest()
        {
            List<Triangle> triangle = new List<Triangle>();
            Triangle triangleFirst = new Triangle("triangle1", 4, 4, 5);
            Triangle triangleSecond = new Triangle("triangle1", 3, 3, 4);
            Triangle triangleThird = new Triangle("triangle1", 7, 7, 6);
            triangle.Add(triangleFirst);
            triangle.Add(triangleSecond);
            triangle.Add(triangleThird);

            List<Triangle> triangleList = new TriangleOperations().SortDescendingBySquare(triangle);
            string actual = triangleList.Max(x => x.GetSquare()).ToString("##.##"); ;
            string expected = triangleThird.GetSquare().ToString("##.##");

            Assert.AreEqual(expected, actual);
        }       
    }
}
