using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter_Calculator
{
    internal class Triangle
    {
        double s1, s2, s3, h;

        public Triangle(int side1, int side2, int side3)
        {
            s1 = side1;
            s2 = side2;
            s3 = side3;
        }
        public Triangle(int side1, int side2, int side3, int height)
        {
            s1 = side1;
            s2 = side2;
            h = height;
        }
        public double calculateArea()
        {
            return s1 * s2 / h;
        }
        public double calculatePerimeter()
        {
            return s1 + s2 + s3;
        }
    }
}