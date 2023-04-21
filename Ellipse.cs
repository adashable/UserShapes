using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserShapes
{
    /*
     * Данный класс является производным от класса фигур Shapes. От него будет наследоваться класс Circle.
     * Содержит два поля (a и b - поля базового класса),
     * переопределённый метод для подсчёта площади эллипса.
     */
    public class Ellipse: Shapes
    {
        public Ellipse() { }
        public Ellipse(double a, double b) : base(a, b) { }
        public override double Area() { return Math.PI * a * b; }
    }
}
