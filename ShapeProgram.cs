using System;

namespace Shape
{
    public class ShapeProgram : MenuProgram
    {
        private List<Shape> shapes;
        public ShapeProgram()
        {
            shapes = new List<Shape>();
        }

        protected override void PrintMenu()
        {
            System.Console.WriteLine("1. Add circle");
            System.Console.WriteLine("2. Add rectangle");
            System.Console.WriteLine("3. Add square");
            System.Console.WriteLine("4. Show all shapes");
            System.Console.WriteLine("0. Quit");
        }

        protected override void Process(int choice)
        {
            switch (choice)
            {
                case 1: AddCircle(); break;
                case 2: AddRectangle(); break;
                case 3: AddSquare(); break;
                case 4: ShowAll(); break;
                case 0: break;
                default: System.Console.WriteLine("Invalid choice"); break;
            }
            
        }

        private void AddCircle()
        {
            System.Console.WriteLine("Add circle information");

            System.Console.Write("Enter name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter Radius: ");
            double radius = Console.ReadLine();

            Circle c = new Circle(name, radius);
            shapes.Add(c);

            System.Console.WriteLine("Circle added successful!");
        }

        private void AddRectangle()
        {
            System.Console.WriteLine("Add rectangle information");

            System.Console.Write("Enter name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter Width: ");
            double width = Console.ReadLine();

            System.Console.Write("Enter Height: ");
            double height = Console.ReadLine();

            Rectangle r = new Rectangle(name, width, height);
            shapes.Add(r);

            System.Console.WriteLine("Rectangle added successful!");
        }

        private void AddSquare()
        {
            System.Console.WriteLine("Add Square information");

            System.Console.Write("Enter name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter Side: ");
            double side = Console.ReadLine();

            Square s = new Square(name, side);
            shapes.Add(s);

            System.Console.WriteLine("Square added successful!");
        }

        public void ShowAll()
        {
            
        }
        
    }
}