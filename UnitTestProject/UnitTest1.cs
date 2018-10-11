using System;
using ModelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GramToOunces()
        {
            Assert.AreEqual(0.352739619, Converter.GramToOunces(10), 0.001);
        }

        [TestMethod]
        public void OuncesToGram()
        {
            Assert.AreEqual(2834.95231, Converter.OuncesToGram(100), 0.001);
        }
    }
}
