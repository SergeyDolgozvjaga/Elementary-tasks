using System;
using System.Collections.Generic;

namespace ElementalTask3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                TriangleOperations operations = new TriangleOperations();
                List<Triangle> triangles = operations.GetTriangles();
                operations.PrintTriangles(operations.SortDescendingBySquare(triangles));
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}
