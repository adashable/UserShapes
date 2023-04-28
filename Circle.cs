using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserShapes
{
    public class Circle: Shape
    {
        private double _radius;
        public double Radius { get { return _radius; } }
        public Circle(double radius) 
        {
            _radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI*_radius*_radius;
        }
    }
}
