using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter_Calculator
{
    internal class Square
    {
        double s1, p;

        public Square(int side1, int perimeter)
        {
            s1 = side1;
            p = perimeter;
        }
        public Square(int side1)
        {
            s1 = side1;

        }
        public double calculateArea()
        {
            return s1 * s1;
        }
        public double calculatePerimeter()
        {
            return s1 * p;
        }
    }
}
