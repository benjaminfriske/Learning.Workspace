using System;

namespace Learning.Workspace.Classtime
{
    public class DelegateClass
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
