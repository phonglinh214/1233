using System;

namespace CustomerManagement
{
    public abstract class MenuProgram
    {
        protected const int Exit = 0;
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                Process(choice);

                running = choice != Exit;
            }
        }
            protected abstract void PrintMenu();
            protected abstract void Process(int choice);
            protected int GetChoice()
            {
                Console.Write("Enter your choice: ");
                return int.Parse(Console.ReadLine());
            }
    }
}