using Learning.Workspace.Classroom;
using Learning.Workspace.Playground;
using System;

namespace Learning.Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var value in Lesson2.CreateSimpleIterator())
            {
                Console.WriteLine("Lazy Evaluation");
            }

            foreach (var value in Lesson2.CreateSimpleList())
            {
                Console.WriteLine("Not Lazy Loaded");
            }
        }
    }
}
