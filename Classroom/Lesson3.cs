using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Workspace.Classroom
{
    public partial class Lesson3
    {
        public Lesson3()
        {
            OnConstruction();
        }

        public string OnConstruction()
        {
            var text = string.Empty;
            Console.WriteLine("Me - What time is it?");
            WhatTimeIsIt(ref text);
            Console.WriteLine($"Computer - {text}");
            return text;
        }

        partial void WhatTimeIsIt(ref string text);
    }

    public partial class Lesson3
    {
        partial void WhatTimeIsIt(ref string text)
        {
            text = "I don't know.";
        }
    }
}
