using Learning.Workspace.Classtime;

namespace Learning.Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass printService = new DelegateClass();
            Printer p1 = new Printer(printService.PrintAnything);
            Printer p2 = printService.PrintAnything;
            Printer p3 = printService.GenericString;
            p1("Hello");
            p2("World");
        }   
    }

    
}
