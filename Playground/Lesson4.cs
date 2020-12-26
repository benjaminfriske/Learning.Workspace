using System;
using System.Collections.Generic;

namespace Learning.Workspace.Playground
{
    public class Lesson4
    {
        public static List<Action> CreateCountingActions()
        {
            List<Action> actions = new List<Action>();
            int outerCounter = 0;
            for (int i = 0; i < 2; i++)
            {
                int innerCounter = 0;
                Action action = () =>
                {
                    Console.WriteLine($" Outer: {outerCounter} Inner: {innerCounter}");
                    outerCounter++;
                    innerCounter++;
                };
                actions.Add(action);
            }
            return actions;
        }
    }
}