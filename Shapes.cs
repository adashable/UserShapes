using System;

namespace UserShapes
{
    /*
     * Данный класс является абстрактнным классом, от которого будут наследоваться все остальные классы фигур.
     * По умолчанию содержит два поля (a - ширина, b - высота), виртуальный метод для подсчёта площади (площадь = a * b).
     */
    public abstract class Shapes
    {
        protected double a { get; set; }
        protected double b { get; set; }
        public Shapes() { }
        public Shapes(double h, double w) 
        { 
            this.a = h;
            this.b = w;
        }

        virtual public double Area() { return a * b ; }
    }
}