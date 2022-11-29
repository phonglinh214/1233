using System;

namespace Shape
{
    public class Rectangle : Shape
    {
        protected double width; 
        protected double height;
        public double Width 
        {
            get { return width; }
            set { width = value; }
        }

        public double Height 
        {
            get { return height; }
            set { height = value; }
        }


        public Rectangle()
        {
            Width = 2;
            Height = 1;
        }

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height; 
        }
        
        public override double GetPrimeter()
        {
            return (Width + Height) * 2;
        }
    }
}