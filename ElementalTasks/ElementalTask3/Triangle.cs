using System;

namespace ElementalTask3
{
    public class Triangle
    {
        private string name;
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public Triangle(string name, double firstSide, double secondSide, double thirdSide)
        {
            this.name = name;
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public string Name { get { return name; } }

        public double FirstSide { get { return firstSide; } }

        public double SecondSide { get { return secondSide; } }

        public double ThirdSide { get { return thirdSide; } }

        public double GetSquare()
        {
            // half of perimeter
            double p = (firstSide + secondSide + thirdSide) / 2;
            // area of ​​a triangle
            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));         
        }
    }
}
