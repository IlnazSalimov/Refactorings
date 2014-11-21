using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrioStroy;
using Brio;
using Brio.Models;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = HtmlExtensions.GetHello();
            Assert.AreEqual(result, "Hello, World!");
        }
    }
}
