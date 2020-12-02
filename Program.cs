using System;

namespace Learning.Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();
            Printer p1 = new Printer(printService.PrintAnything);
            Printer p2 = printService.PrintAnything;

            p1("Hello");
            p2("World");
        }

        
    }
    public class PrintService
    {
        public void PrintAnything(object obj)
        {
            Console.WriteLine(obj);
        }
    }

    public delegate void Printer(string message);
}
