using System;
using System.Collections.Generic;

namespace Learning.Workspace.Playground
{
    public class Lesson4
    {
        public static int outerActionCounter;
        public static int innerActionCounter;
        public static List<Action> CreateCountingActions()
        {
            List<Action> actions = new List<Action>();
            int outerCounter = 0;
            for (int i = 0; i < 2; i++)
            {
                int innerCounter = 0;
                Action action = () =>
                {
                    outerActionCounter = outerCounter;
                    innerActionCounter = innerCounter;
                    outerCounter++;
                    innerCounter++;
                };
                actions.Add(action);
            }
            return actions;
        }

        public void SimpleOptionalNamedArgument(string arg1, string arg2 = "test", int arg3 = 3)
        {
            // This method can be called many ways.
            Console.WriteLine($"Argument 1: {arg1}");
            Console.WriteLine($"Argument 2: {arg2}");
            Console.WriteLine($"Argument 3: {arg3}");
        }
    }
}