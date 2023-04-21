using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserShapes
{
    /*
     * Данный класс является производным от класса фигур Shapes.
     * Содержит три поля (a и b - поля базового класса, c - поле данного класса),
     * конструктор, выкидывающий исключение при попытке создания треугольника, не соответствующего теореме о соотношении длин сторон треугольника,
     * переопределённый метод для подсчёта площади треугольника (используется формула площади треугольника через полупериметр),
     * метод IsRight(), проверяющий, является треугольник прямоугольным (true) или нет (false).
     */
    public class Triangle: Shapes
    {
        protected double c { get; set; }
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

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRight()
        {
            if(((a * a + b * b) == c * c) || ((c * c + b * b) == a * a) || ((a * a + c * c) == b * b))
            {
                return true;
            }
            else { return false; }
        }
    }
}
