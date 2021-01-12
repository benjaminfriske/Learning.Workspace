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

        [TestMethod]
        public void SimpleOptionalNamedArgument_TestAllDifferentWays_ThisMakesOptionialFlexible()
        {
            Lesson4 test = new Lesson4();
            bool didItFail = false;
            try
            {
                test.SimpleOptionalNamedArgument("hello world!");
                test.SimpleOptionalNamedArgument(arg1: "", arg3: 10); 
                test.SimpleOptionalNamedArgument("this works too!", "only arg 2 set."); 
                test.SimpleOptionalNamedArgument("wow this is index, but 3rd argument is named.", arg3: 25);
                didItFail = false;
            }
            finally
            {
                Assert.IsFalse(didItFail);
            }
        }
    }
}
