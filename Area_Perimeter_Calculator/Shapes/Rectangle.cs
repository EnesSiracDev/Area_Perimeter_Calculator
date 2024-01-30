using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter_Calculator
{
    internal class Rectangle
    {
        double s1, s2, p;

        public Rectangle(int side1, int side2)
        {
            s1 = side1;
            s2 = side2;
        }
        public Rectangle(int side1, int side2, int perimeter)
        {
            s1 = side1;
            s2 = side2;
            p = perimeter;
        }
        public double calculateArea()
        {
            return s1 * s2;
        }
        public double calculatePerimeter()
        {
            return 2 * (s1 + s2);
        }
    }
}
