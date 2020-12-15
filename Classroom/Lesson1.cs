using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Workspace.Classroom
{
    public class Lesson1
    {
        /// <summary>
        /// Lesson1 printService = new Lesson1();
        /// Printer p2 = printService.PrintAnything;
        /// Printer p3 = printService.GenericString;
        /// p1("Hello");
        /// p2("World");
        /// </summary>
        public Lesson1()
        {
            
        }

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
