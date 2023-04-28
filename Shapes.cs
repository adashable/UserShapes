using System;

namespace UserShapes
{
    public abstract class Shape : IShape
    {
        public abstract double GetArea();
    }

    public interface IShape 
    {
        public double GetArea();
    }
}