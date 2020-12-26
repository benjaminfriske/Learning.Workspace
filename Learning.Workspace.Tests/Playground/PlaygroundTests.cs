using Learning.Workspace.Playground;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Learning.Workspace.Tests.Playground
{
    [TestClass]
    public class PlaygroundTests
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void CreateCountingActions_ReturnListOfActions_EmptySet()
        {
            List<Action> actions = Lesson4.CreateCountingActions();
            actions[0]();
            actions[0]();
            actions[1]();
            actions[1]();
        }
    }
}
