using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementalTask3
{
    public class TriangleOperations
    {

        public List<Triangle> GetTriangles()
        {
            String answer = "";
            List<Triangle> triangles = new List<Triangle>();
            do
            {
                try
                {
                    Console.WriteLine("Please, enter name and sides of triangle."
                            + " Format: <Name>,<1-st side>,<2-nd side>,<3-rd side>");

                    string textTriangle = Console.ReadLine();
                    string[] partsOfTriangle = textTriangle.Split(',');
                    string name = partsOfTriangle[0];
                    double firstSide = Convert.ToDouble(partsOfTriangle[1]);
                    double secondSide = Convert.ToDouble(partsOfTriangle[2]);
                    double thirdSide = Convert.ToDouble(partsOfTriangle[3]);

                    if (TriangleValidator.IsValidSizeTriangle(firstSide, secondSide, thirdSide))
                    {
                        triangles.Add(new Triangle(name, firstSide, secondSide, thirdSide));
                        Console.WriteLine("Do you want to add new one?");
                        answer = Console.ReadLine();
                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Unfortunatelly, inserted number is in the invalid number format");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Inserted 'whitespace' is in the invalid number format");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Unfortunatelly, inserted number is too long");                    
                }

            } while (TriangleValidator.IsContinue(answer));
            return triangles;
        }

        public List<Triangle> SortDescendingBySquare(List<Triangle> triangle)
        {
            IEnumerable<Triangle> sorted = triangle;
            return sorted.OrderByDescending(x => x.GetSquare()).ToList();
        }

        public void PrintTriangles(List<Triangle> triangle)
        {
            List<Triangle> triangleList = triangle;

            int i = 1;
            foreach (Triangle triangles in triangleList)
            {
                Console.WriteLine(
                        i + ". [Triangle " + triangles.Name 
                        + "]: Square = "   + triangles.GetSquare().ToString("##.##") + " cm^2 ");
                i++;
            }
        }
    }
}
