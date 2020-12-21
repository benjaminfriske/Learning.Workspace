using System;
using System.Collections.Generic;

namespace Learning.Workspace.Classroom
{
    /// <summary>
    /// try
    //  {
    //      foreach (var value in Lesson2.CreateSimpleIterator())
    //      {
    //          Console.WriteLine("Lazy Evaluation");
    //      }

    //      foreach (var value in Lesson2.CreateSimpleList())
    //      {
    //          Console.WriteLine("Not Lazy Loaded");
    //      }
    //  }
    //  catch(Exception e)
    //  {
    //      Console.WriteLine($"Error: {e.Message}");
    //  }
    /// </summary>
    public static class Lesson2
    {
        public static IEnumerable<int> CreateSimpleIterator()
        {
            try 
            {
                yield return 10;
                Console.WriteLine("10");
                yield return 5;
                Console.WriteLine("5");
                // throw(new NotImplementedException());
                yield return 25;
                Console.WriteLine("25");
            }
            finally
            {
                Console.WriteLine("finally block");
            }
            
        }

        public static List<int> CreateSimpleList()
        {
            List<int> test = new List<int>();
            test.Add(10);
            Console.WriteLine("10");
            test.Add(5);
            Console.WriteLine("5");
            throw(new NotImplementedException());
            test.Add(25);
            Console.WriteLine("25");
            return test;
        }
    }
}
