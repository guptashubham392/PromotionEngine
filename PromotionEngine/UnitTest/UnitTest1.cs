using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //First Test Case
            int expected = 100;
            int result = Program.GetTotalPrice("A,B,C");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Second Test Case
            int expected = 370;
            int result = Program.GetTotalPrice("A,A,A,A,A,B,B,B,B,B,C");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Third Test Case
            int expected = 280;
            int result = Program.GetTotalPrice("A,A,A,B,B,B,B,B,C,D");
            Assert.AreEqual(expected, result);
        }
    }
}
