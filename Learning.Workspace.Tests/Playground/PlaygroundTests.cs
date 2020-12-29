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
            Assert.AreEqual(Lesson4.outerActionCounter, 0);
            Assert.AreEqual(Lesson4.innerActionCounter, 0);
            actions[0]();
            Assert.AreEqual(Lesson4.outerActionCounter, 1);
            Assert.AreEqual(Lesson4.innerActionCounter, 1);
            actions[1]();
            Assert.AreEqual(Lesson4.outerActionCounter, 2);
            Assert.AreEqual(Lesson4.innerActionCounter, 0);
            actions[1]();
            Assert.AreEqual(Lesson4.outerActionCounter, 3);
            Assert.AreEqual(Lesson4.innerActionCounter, 1);
        }
    }
}
