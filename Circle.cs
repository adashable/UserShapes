using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserShapes
{
    /*
     * Данный класс является производным от класса эллипса Ellipse.
     * Содержит два поля (a и b - поля базового класса),
     * в качестве аргумента для конструктора исопльзуется только один аргумент - радиус.
     */
    public class Circle: Ellipse
    {
        public Circle(double r): base(r, r) { }

    }
}
