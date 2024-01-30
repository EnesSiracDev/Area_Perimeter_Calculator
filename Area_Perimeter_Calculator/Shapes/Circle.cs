using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter_Calculator
{
    internal class Circle
    {
        double r, pi, t;

        public Circle(double radius, double piNumber)
        {
            r = radius;
            pi = piNumber;
        }
        public Circle(double radius, double piNumber, double two)
        {
            r = radius;
            pi = piNumber;
            t = two;
        }
        public double calculateArea()
        {
            return pi * (r * r);
        }
        public double calculatePerimeter()
        {
            return t * pi * r;
        }
    }
}
