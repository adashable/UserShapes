using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserShapes
{
    public class Triangle: Shape
    {
        private double a;
        private double b;
        private double c;
        /// <summary>
        /// Checking the main theorem of the triangle
        /// </summary>
        /// <param name="a1">first side</param>
        /// <param name="b1">second side</param>
        /// <param name="c1">third side</param>
        /// <returns></returns>
        protected bool CheckSides(double a1, double b1, double c1)
        {
            if((a1 + b1 > c1) && (c1 + b1 > a1) && (a1 + c1 > b1))
            {
                return true;
            }
            return false;
        }
        public Triangle(double a1, double b1, double c1) 
        { 
            if(CheckSides(a1, b1, c1))
            {
                a = a1;
                b = b1;
                c = c1;
            }
            else
            {
                throw new Exception("Треугольник с данными параметрами не может существовать.");
            }
        }

        public override double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRightTriangle()
        {
            if(((a * a + b * b) == c * c) || ((c * c + b * b) == a * a) || ((a * a + c * c) == b * b))
            {
                return true;
            }
            else { return false; }
        }
    }
}
