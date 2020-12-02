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
            Printer p3 = printService.GenericString;


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

        public void GenericString(string str)
        {
            Console.WriteLine(str);
        }

        public void GenericWriteLine()
        {
            Console.WriteLine("here we go!");
        }

        public string GenericStringReturn(string str)
        {
            Console.WriteLine(str);
            return string.Empty;
        }
    }

    public delegate void Printer(string message);
}
