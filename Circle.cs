using System;

namespace Shape
{
    public class Circle : Shape
    {
        protected double radius;
        public double Radius 
        {
            get { return radius; }
            set 
            { 
                if (value < 0) radius = 1;
                else radius = value; 
            } 
        }
        public Circle() 
        {
            Radius = 1;
        }
        public Circle(string name, int radius) : base(name)
        {
            Radius = radius; 
        }

        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 3.14 * 2 * Radius;
        }
    }
}