using System;

namespace Shape
{
    public abstract class Shape
    {
        protected string name;
        public string Name  
        {
            get { return name; } 
            set { name = value; }
        }

        public Shape(string name)
        {
            Name = name;
        }
        public  Shape()
        {
            Name = "Shape";
        }
        public abstract double GetArea();
        public abstract double GetPrimeter();
        public virtual void ShowInfo()
        {
            System.Console.WriteLine("Name: " + Name + ", Area: " + GetArea + ", Primeter: " + GetPrimeter);
        }
    }
}