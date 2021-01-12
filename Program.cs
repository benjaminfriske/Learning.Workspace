using Learning.Workspace.Classroom;
using Learning.Workspace.Playground;

namespace Learning.Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            Lesson4 test = new Lesson4();
            test.SimpleOptionalNamedArgument("hello world!");
            test.SimpleOptionalNamedArgument(arg1: "", arg3: 10);
            test.SimpleOptionalNamedArgument("this works too!", "only arg 2 set.");
            test.SimpleOptionalNamedArgument("wow this is index, but 3rd argument is named.", arg3: 25);
        }
    }
}
